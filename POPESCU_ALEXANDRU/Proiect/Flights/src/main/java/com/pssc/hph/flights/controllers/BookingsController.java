package com.pssc.hph.flights.controllers;

import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.services.BookingsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/home")
public class BookingsController {

    @Autowired
    BookingsService bookingsService;

    @GetMapping("bookings")
    public List<Booking> getAll(){
       return bookingsService.getAllBookings();
    }
}
