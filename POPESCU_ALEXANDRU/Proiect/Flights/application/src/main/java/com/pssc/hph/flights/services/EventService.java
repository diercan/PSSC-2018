package com.pssc.hph.flights.services;

import com.pssc.hph.flights.entities.Event;
import com.pssc.hph.flights.repositories.EventRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class EventService {
    private final EventRepository eventRepository;


    public List<Event> getEvents() {
      return eventRepository.findAll();

    }
}
