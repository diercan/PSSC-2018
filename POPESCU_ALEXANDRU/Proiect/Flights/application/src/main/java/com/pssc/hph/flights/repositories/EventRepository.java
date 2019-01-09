package com.pssc.hph.flights.repositories;

import com.pssc.hph.flights.entities.Event;
import org.springframework.data.jpa.repository.JpaRepository;

public interface EventRepository extends JpaRepository<Event, Long> {
}
