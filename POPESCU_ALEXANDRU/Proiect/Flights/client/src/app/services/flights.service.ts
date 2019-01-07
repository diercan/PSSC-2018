import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Flight} from "../models/flight";
import conf from "../configs/conf";

@Injectable({
  providedIn: 'root'
})
export class FlightsService {

  constructor(private http: HttpClient) { }

  getAll(callback) {
    this.http.get(conf.basePath + '/flights').subscribe(callback, () => alert('Could not retrieve flights!'));
  }

  create(value, success) {
    this.http.post(conf.basePath + '/flights', value).subscribe((flight: Flight) => success(flight), () => alert('Could not create flight!'))
  }

  getOne(id: number, success) {
    this.http.get(conf.basePath + '/flights/' + id).subscribe((flight: Flight) => success(flight), () => alert('Could not retrieve flight!'));
  }

  notify(id: number) {
    this.http.post(conf.basePath + '/flights/' + id + '/notify', {}).subscribe(() => {}, () => alert('Could not notify users about this flight'));
  }

  remove(id: number, success) {
    this.http.delete(conf.basePath + '/flights/' + id).subscribe(() => success(), () => alert('Could not remove this flight!'));
  }
}
