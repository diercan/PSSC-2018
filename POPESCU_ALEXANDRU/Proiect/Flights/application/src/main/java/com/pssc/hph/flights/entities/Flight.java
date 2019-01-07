package com.pssc.hph.flights.entities;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.time.LocalDateTime;
import java.util.List;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Flight {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    private String fromCity;
    private String toCity;
    private LocalDateTime time;
    @JsonIgnore
    @OneToMany(mappedBy = "flight", fetch = FetchType.EAGER)
    private List<Booking> bookings;
    @ManyToOne
    private Airplane airplane;
    private int sentEmails;
    private boolean allEmailsSent = false;
    private int seatsTaken;
}
