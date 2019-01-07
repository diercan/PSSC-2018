package com.pssc.hph.flights.repositories;

import com.pssc.hph.flights.entities.Booking;
import com.pssc.hph.flights.entities.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface BookingRepository extends JpaRepository<Booking, Long> {


    List<Booking> findAllByUser(User user);
}
