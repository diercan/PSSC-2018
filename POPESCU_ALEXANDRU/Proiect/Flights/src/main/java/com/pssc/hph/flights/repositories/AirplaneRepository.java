package com.pssc.hph.flights.repositories;

import com.pssc.hph.flights.entities.Airplane;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AirplaneRepository extends JpaRepository<Airplane, Integer> {
}
