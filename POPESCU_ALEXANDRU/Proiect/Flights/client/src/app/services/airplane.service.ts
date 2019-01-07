import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import conf from "../configs/conf";

@Injectable({
  providedIn: 'root'
})
export class AirplaneService {

  constructor(private http: HttpClient) { }

  getAll(callback) {
    this.http.get(conf.basePath + '/airplanes').subscribe(callback, () => alert('Could not retrieve airplanes!'));
  }
}
