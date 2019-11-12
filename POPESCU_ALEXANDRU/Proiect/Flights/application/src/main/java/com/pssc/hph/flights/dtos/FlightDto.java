package com.pssc.hph.flights.dtos;

import lombok.Data;

import java.time.LocalDateTime;

@Data
public class FlightDto {
    private String fromCity;
    private String toCity;
    private LocalDateTime time;
    private long airplaneId;
}
