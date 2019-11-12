package com.pssc.hph.flights.services;

import com.pssc.hph.flights.dtos.BookingDto;
import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.entities.Event;
import com.pssc.hph.flights.exceptions.BadRequestFlightsException;
import com.pssc.hph.flights.exceptions.NotFoundFlightsException;
import com.pssc.hph.flights.repositories.BookingRepository;
import com.pssc.hph.flights.repositories.EventRepository;
import com.pssc.hph.flights.repositories.FlightRepository;
import lombok.RequiredArgsConstructor;
import lombok.val;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;

@Service
@RequiredArgsConstructor
public class BookingService {
    private final BookingRepository bookingRepository;
    private final FlightRepository flightRepository;
    private final EventRepository eventRepository;
    private final UserService userService;

    public List<Booking> getAllBookings() {
        eventRepository.save(Event.builder()
                .type("read")
                .details("all bookings")
                .timestamp(LocalDateTime.now())
                .user(userService.getPrincipal())
                .build()
        );

        return bookingRepository.findAllByUser(userService.getPrincipal());
    }

    public Booking createBooking(BookingDto bookingDto) {
        val booking = new Booking();

        val flight = flightRepository.findById(bookingDto.getFlightId()).orElseThrow(NotFoundFlightsException::new);

        if (flight.getSeatsTaken() >= flight.getAirplane().getAvailableSeats()) {
            throw new BadRequestFlightsException();
        }

        val user = userService.getPrincipal();

        flight.setSeatsTaken(flight.getSeatsTaken() + 1);

        booking.setFlight(flight);
        booking.setUser(user);
        bookingRepository.save(booking);

        eventRepository.save(Event.builder()
            .type("create")
            .details("booking " + booking.getId())
            .user(user)
            .timestamp(LocalDateTime.now())
            .build()
        );

        return booking;
    }

    public void delete(long id) {
        bookingRepository.deleteById(id);
        eventRepository.save(Event.builder()
                .type("delete")
                .details("booking " + id)
                .timestamp(LocalDateTime.now())
                .user(userService.getPrincipal())
                .build()
        );
    }
}
