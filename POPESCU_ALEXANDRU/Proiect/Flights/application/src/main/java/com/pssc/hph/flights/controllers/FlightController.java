package com.pssc.hph.flights.controllers;

import com.pssc.hph.flights.dtos.BookingDto;
import com.pssc.hph.flights.dtos.FlightDto;
import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.entities.Flight;
import com.pssc.hph.flights.services.FlightService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/flights")
@RequiredArgsConstructor
public class FlightController {
    private final FlightService flightService;

    @GetMapping
    public List<Flight> flights() {
        return flightService.getAll();
    }

    @GetMapping("/{id}")
    public Flight get(@PathVariable long id) {
        return flightService.getOne(id);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable long id) {
        flightService.delete(id);
    }

    @PostMapping
    public Flight createFlight(@RequestBody FlightDto flightDto) {
        return flightService.createFlight(flightDto);
    }

    @PostMapping("/{id}/notify")
    public void notifyUsers(@PathVariable long id) {
        flightService.notifyUsers(id);
    }
}
