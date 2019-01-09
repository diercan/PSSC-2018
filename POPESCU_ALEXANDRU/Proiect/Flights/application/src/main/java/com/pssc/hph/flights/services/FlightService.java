package com.pssc.hph.flights.services;

import com.pssc.hph.flights.dtos.FlightDto;
import com.pssc.hph.flights.entities.Event;
import com.pssc.hph.flights.entities.Flight;
import com.pssc.hph.flights.entities.User;
import com.pssc.hph.flights.exceptions.BadRequestFlightsException;
import com.pssc.hph.flights.exceptions.NotFoundFlightsException;
import com.pssc.hph.flights.repositories.AirplaneRepository;
import com.pssc.hph.flights.repositories.EventRepository;
import com.pssc.hph.flights.repositories.FlightRepository;
import com.pssc.hph.flights.repositories.UserRepository;
import lombok.RequiredArgsConstructor;
import lombok.SneakyThrows;
import lombok.extern.slf4j.Slf4j;
import lombok.val;
import org.springframework.scheduling.annotation.Async;
import org.springframework.stereotype.Service;

import javax.persistence.EntityNotFoundException;
import java.time.LocalDateTime;
import java.util.List;

@Slf4j
@Service
@RequiredArgsConstructor
public class FlightService {
    private final FlightRepository flightRepository;
    private final AirplaneRepository airplaneRepository;
    private final UserRepository userRepository;
    private final EventRepository eventRepository;
    private final UserService userService;


    public Flight createFlight(FlightDto flightDto) {
//    User user = new User();

        eventRepository.save(Event.builder()
                .type("create")
                .details("create flight by ADMIN")
                .timestamp(LocalDateTime.now())
//                .user("ADMIN")
                .build()
        );


        val airplane = airplaneRepository.findById(flightDto.getAirplaneId()).orElseThrow(NotFoundFlightsException::new);
        if(flightDto.getFromCity() == null || flightDto.getFromCity().length() < 2 ||
                flightDto.getToCity() == null || flightDto.getToCity().length() < 2 ||
                flightDto.getTime() == null || flightDto.getTime().isBefore(LocalDateTime.now().plusDays(1))) {
            throw new BadRequestFlightsException();
        }

        val flight = new Flight();
        flight.setAirplane(airplane);
        flight.setFromCity(flightDto.getFromCity());
        flight.setToCity(flightDto.getToCity());
        flight.setTime(flightDto.getTime());
        flight.setAllEmailsSent(false);

        return flightRepository.save(flight);
    }

    @Async
    public void notifyUsers(long id) {

        val flight = flightRepository.findById(id).orElseThrow(NotFoundFlightsException::new);
        val users = userRepository.findAll();
        notifyAsync(flight, users);
    }

    @SneakyThrows
    public void notifyAsync(Flight flight, List<User> users) {


        for (User user : users) {
            Thread.sleep(3000);

            flight.setSentEmails(flight.getSentEmails() + 1);
            flightRepository.save(flight);
            log.info("Email sent to user {}@{}", user.getUsername(), user.getEmail());
        }

        flight.setAllEmailsSent(true);
        flightRepository.save(flight);
        eventRepository.save(Event.builder()
                        .type("notify")
                        .details(" notify all users")
                        .timestamp(LocalDateTime.now())
//                .user(userService.getPrincipal())
                        .build()
        );

        log.info("All email notifications successfully sent.");

    }

    public List<Flight> getAll() {
//        eventRepository.save(Event.builder()
//                .type("read")
//                .details("read all flights as admin")
//                .timestamp(LocalDateTime.now())
//                .user(userService.getPrincipal())
//                .build()
//        );
        return flightRepository.findAll();

    }

    public Flight getOne(long id) {
        return flightRepository.findById(id).orElseThrow(EntityNotFoundException::new);
    }

    public void delete(long id) {
//        eventRepository.save(Event.builder()
//                .type("delete")
//                .details("delete a flight")
//                .timestamp(LocalDateTime.now())
//                .user(userService.getPrincipal())
//                .build()
//        );
        flightRepository.deleteById(id);
    }
}
