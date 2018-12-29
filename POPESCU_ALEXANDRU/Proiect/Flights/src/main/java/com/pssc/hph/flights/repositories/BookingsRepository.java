package com.pssc.hph.flights.repositories;

import com.pssc.hph.flights.entities.Booking;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BookingsRepository extends JpaRepository<Booking,Integer> {
}
