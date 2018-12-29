package com.pssc.hph.flights.controllers;

import com.pssc.hph.flights.entities.Airplane;
import com.pssc.hph.flights.services.AirplaneService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/home/airplane")
public class AirplanesController {

    @Autowired
    AirplaneService airplaneService;

    @GetMapping("/all")
    public List<Airplane> getAirplanes(){
        return airplaneService.getAllAirplanes();
    }


}
