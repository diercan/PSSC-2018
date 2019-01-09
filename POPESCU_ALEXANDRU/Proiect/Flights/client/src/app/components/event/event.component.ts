import { Component, OnInit } from '@angular/core';
import { Events } from 'src/app/models/events';
import { EventService } from 'src/app/services/event.service';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {
  events: Events[] = [];

  constructor(private eventService : EventService,
              private auth: AuthService) { }

  ngOnInit() {
    this.eventService.getAllEvents((result : Events[]) =>
    this.events = result);
  }

}
