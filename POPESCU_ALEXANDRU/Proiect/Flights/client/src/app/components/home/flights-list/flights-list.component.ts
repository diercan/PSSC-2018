import { Component, OnInit } from '@angular/core';
import {FlightsService} from "../../../services/flights.service";
import {Flight} from "../../../models/flight";
import {Router} from "@angular/router";
import {BookingService} from "../../../services/booking.service";
import {User} from "../../../models/user";
import {AuthService} from "../../../services/auth.service";

@Component({
  selector: 'app-flights-list',
  templateUrl: './flights-list.component.html',
  styleUrls: ['./flights-list.component.css']
})
export class FlightsListComponent implements OnInit {
  flights: Flight[] = [];
  user: User;

  constructor(private flightsService: FlightsService,
              private bookingService: BookingService,
              private auth: AuthService
              ) { }

  ngOnInit() {
    this.user = this.auth.getAuthenticatedUser();
    this.flightsService.getAll((result: Flight[]) => {
      this.flights = result;
    })
  }

  createBooking(id: number) {
    if(this.user.role !== 'CUSTOMER') {
      return;
    }

    if(!confirm('Are you sure you want to book this flight?')) {
      return;
    }

    this.bookingService.createBooking(id, () => {
      this.flightsService.getAll((result: Flight[]) => {
        this.flights = result;
      })
    });
  }

  removeFlight(id: number) {
    if(!confirm('Are you sure you want to remove this flight?')) {
      return;
    }

    this.flightsService.remove(id, () => {
      this.flightsService.getAll((result: Flight[]) => {
        this.flights = result;
      })
    });
  }
}
