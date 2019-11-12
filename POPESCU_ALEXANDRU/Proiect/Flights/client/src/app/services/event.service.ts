import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import conf from '../configs/conf';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  constructor(private http : HttpClient) { }

  getAllEvents(callback){
    this.http.get(conf.basePath + '/events').subscribe(callback, () => alert("Could not retrive the events"));
  }
}
