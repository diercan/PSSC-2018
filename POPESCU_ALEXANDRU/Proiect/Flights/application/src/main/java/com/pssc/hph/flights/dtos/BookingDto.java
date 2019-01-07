package com.pssc.hph.flights.dtos;

import com.pssc.hph.flights.entities.Flight;
import com.pssc.hph.flights.entities.User;
import lombok.Data;

import javax.persistence.ManyToOne;

@Data
public class BookingDto {
    private long flightId;
}
