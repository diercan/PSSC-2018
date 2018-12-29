package com.pssc.hph.flights.entities;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.List;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Airplane {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "id_airplane")
    private int id;
    @Column(name = "places")
    private double places;
    @OneToMany(mappedBy = "id_booking")
    @JsonIgnore
    private List<Booking> id_booking;
}
