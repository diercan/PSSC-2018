import {Component, OnInit, ViewChild} from '@angular/core';
import {Airplane} from "../../models/airplane";
import {AirplaneService} from "../../services/airplane.service";
import {FlightsService} from "../../services/flights.service";
import {NgForm} from "@angular/forms";
import {Flight} from "../../models/flight";
import {interval} from "rxjs/internal/observable/interval";

@Component({
  selector: 'app-manage-flights',
  templateUrl: './manage-flights.component.html',
  styleUrls: ['./manage-flights.component.css']
})
export class ManageFlightsComponent implements OnInit {
  @ViewChild('flightForm') flightForm: NgForm;
  airplanes: Airplane[] = [];
  flight: Flight = null;

  constructor(private airplaneService: AirplaneService,
              private flightService: FlightsService) { }

  ngOnInit() {
    this.airplaneService.getAll((result: Airplane[]) => this.airplanes = result);
  }

  createFlight() {
    this.flightService.create(this.flightForm.value, (flight: Flight) => {
      this.flightService.notify(flight.id);
      debugger

      this.flight = flight;
      const interval = setInterval(() => {
        if(this.flight.allEmailsSent) {
          clearInterval(interval);
          return;
        }

        this.flightService.getOne(flight.id, (flight: Flight) => this.flight = flight);
      }, 1000);
    });
  }
}
