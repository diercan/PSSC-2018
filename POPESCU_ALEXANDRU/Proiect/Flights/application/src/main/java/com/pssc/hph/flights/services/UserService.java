package com.pssc.hph.flights.services;

import com.pssc.hph.flights.configs.WebSecurityConfiguration;
import com.pssc.hph.flights.entities.Event;
import com.pssc.hph.flights.entities.Role;
import com.pssc.hph.flights.entities.User;
import com.pssc.hph.flights.exceptions.BadRequestFlightsException;
import com.pssc.hph.flights.exceptions.NotFoundFlightsException;
import com.pssc.hph.flights.repositories.EventRepository;
import com.pssc.hph.flights.repositories.UserRepository;
import lombok.RequiredArgsConstructor;
import lombok.val;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.stereotype.Service;

import java.security.Principal;
import java.time.LocalDateTime;

@Service
@RequiredArgsConstructor
public class UserService {
    private final UserRepository userRepository;
    private final EventRepository eventRepository;

    public User getUser(final String username) {
        return userRepository.findByUsername(username).orElseThrow(NotFoundFlightsException::new);
    }

    public User createUser(User user) {
        if(user.getEmail() == null || user.getEmail().length() < 3 ||
                user.getFirstName() == null || user.getFirstName().length() < 3 ||
                user.getLastName() == null || user.getLastName().length() < 3 ||
                user.getPassword() == null || user.getPassword().length() < 3) {
            throw new BadRequestFlightsException();
        }
        eventRepository.save(Event.builder()
                        .type("create")
                        .details("user " + user.getUsername() +" has been registered")
                        .timestamp(LocalDateTime.now())
//                        .user(user.getId())
                        .build()
        );

        if(userRepository.findByEmail(user.getEmail()).isPresent() || userRepository.findByUsername(user.getUsername()).isPresent()) {
            throw new BadRequestFlightsException();
        }

        val out = new User();
        out.setEmail(user.getEmail());
        out.setPassword(user.getPassword());
        out.setFirstName(user.getFirstName());
        out.setLastName(user.getLastName());
        out.setUsername(user.getUsername());
        out.setRole(Role.CUSTOMER);

//        eventRepository.save(Event.builder()
//                .type("delete")
//                .details("delete a flight")
//                .timestamp(LocalDateTime.now())
//                .user(getPrincipal())
//                .build()
//        );
        return userRepository.save(out);



    }

    public User getPrincipal() {
        val principal = SecurityContextHolder.getContext().getAuthentication().getPrincipal();
        String name;

        if(principal instanceof Principal) {
            name = ((Principal) principal).getName();
        } else {
            name = ((WebSecurityConfiguration.UserDetailsImpl) principal).getUsername();
        }

        return userRepository.findByUsername(name).orElseThrow(NotFoundFlightsException::new);
    }
}
