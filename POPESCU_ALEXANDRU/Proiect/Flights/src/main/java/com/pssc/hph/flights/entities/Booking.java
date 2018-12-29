package com.pssc.hph.flights.entities;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Booking {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "id_booking")
    private int id_booking;
    @Column(name = "from")
    private String from;
    @Column(name = "to")
    private String to;
    @Column(name = "date_year")
    private String date_year;
    @Column(name = "date_hour")
    private String date_hour;
    @Column(name = "traveltime")
    private String travel_time;
}
