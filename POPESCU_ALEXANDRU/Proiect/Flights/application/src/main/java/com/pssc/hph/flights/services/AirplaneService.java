package com.pssc.hph.flights.services;

import com.pssc.hph.flights.entities.Airplane;
import com.pssc.hph.flights.repositories.AirplaneRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class AirplaneService {
    private AirplaneRepository airplaneRepository;

    @Autowired
    public AirplaneService(AirplaneRepository airplaneRepository) {
        this.airplaneRepository = airplaneRepository;
    }

    public List<Airplane> getAllAirplanes(){
        return airplaneRepository.findAll();
    }
}
