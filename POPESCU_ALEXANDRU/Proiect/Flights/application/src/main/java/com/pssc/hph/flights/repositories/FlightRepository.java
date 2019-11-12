package com.pssc.hph.flights.repositories;

import com.pssc.hph.flights.entities.Flight;
import org.springframework.data.jpa.repository.JpaRepository;

public interface FlightRepository extends JpaRepository<Flight, Long> {
}
