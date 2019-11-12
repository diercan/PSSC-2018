import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import conf from "../configs/conf";

@Injectable({
  providedIn: 'root'
})
export class BookingService {

  constructor(private http: HttpClient) { }

  getAll(callback) {
    this.http.get(conf.basePath + '/bookings').subscribe(callback, () => alert('Could not retrieve bookings!'));
  }

  createBooking(flightId: number, success) {
    this.http.post(conf.basePath + '/bookings', { flightId }).subscribe(() => success(), () => alert('Could not book this flight'))
  }

  remove(id: number, success) {
    this.http.delete(conf.basePath + '/bookings/' + id).subscribe(() => success(), () => alert('Could not remove this booking'))
  }
}
