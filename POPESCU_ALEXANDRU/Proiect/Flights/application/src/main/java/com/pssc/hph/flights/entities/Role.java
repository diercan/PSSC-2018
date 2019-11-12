package com.pssc.hph.flights.entities;

public enum Role {
    CUSTOMER, ADMIN;

    public String getAuthority() {
        return "ROLE_" + this.name().toUpperCase();
    }
}
