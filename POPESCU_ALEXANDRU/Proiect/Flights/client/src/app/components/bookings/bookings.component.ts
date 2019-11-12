import { Component, OnInit } from '@angular/core';
import {Booking} from "../../models/booking";
import {BookingService} from "../../services/booking.service";

@Component({
  selector: 'app-bookings',
  templateUrl: './bookings.component.html',
  styleUrls: ['./bookings.component.css']
})
export class BookingsComponent implements OnInit {
  bookings: Booking[] = [];

  constructor(private bookingService: BookingService) { }

  ngOnInit() {
    this.bookingService.getAll((result: Booking[]) => {
      this.bookings = result;
    })
  }

  removeBooking(id: number) {
    if(!confirm('Are you sure you want to remove this booking?')) {
      return;
    }

    this.bookingService.remove(id, () => this.bookings = this.bookings.filter((booking: Booking) => booking.id != id));
  }
}
