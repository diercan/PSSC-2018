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
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    @Column(unique = true, length = 50)
    private String username;
    @Column(unique = true, length = 50)
    private String email;
    private String password;
    private String firstName;
    private String lastName;
    @JsonIgnore
    @OneToMany(mappedBy = "user")
    private List<Booking> bookings;
    @JsonIgnore
    @OneToMany(mappedBy = "user")
    private List<Event> events;
    @Enumerated(EnumType.STRING)
    private Role role;
}
