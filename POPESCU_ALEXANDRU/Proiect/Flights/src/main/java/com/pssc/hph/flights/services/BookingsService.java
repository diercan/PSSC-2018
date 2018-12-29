package com.pssc.hph.flights.services;

import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.repositories.BookingsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class BookingsService {

    private BookingsRepository bookingsRepository;

    @Autowired
    public BookingsService(BookingsRepository bookingsRepository) {
        this.bookingsRepository = bookingsRepository;
    }

    public List<Booking> getAllBookings(){
        return bookingsRepository.findAll();
    }
}
