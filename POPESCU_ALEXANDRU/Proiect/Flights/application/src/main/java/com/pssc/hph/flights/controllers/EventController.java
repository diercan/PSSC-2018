package com.pssc.hph.flights.controllers;

import com.pssc.hph.flights.entities.Event;
import com.pssc.hph.flights.services.EventService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/events")
public class EventController {
    private final EventService eventService;

    @GetMapping()
    public List<Event> getAllEvents(){
        return eventService.getEvents();
    }


}
