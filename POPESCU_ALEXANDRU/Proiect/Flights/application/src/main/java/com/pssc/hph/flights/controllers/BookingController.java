package com.pssc.hph.flights.controllers;

import com.pssc.hph.flights.dtos.BookingDto;
import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.services.BookingService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/bookings")
@RequiredArgsConstructor
public class BookingController {
    private final BookingService bookingService;

    @GetMapping
    public List<Booking> getAll() {
       return bookingService.getAllBookings();
    }

    @PostMapping
    public Booking createBooking(@RequestBody BookingDto bookingDto) {
        return bookingService.createBooking(bookingDto);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable long id) {
        bookingService.delete(id);
    }
}
