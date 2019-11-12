import {Airplane} from "./airplane";

export class Flight {
  id: number;
  fromCity: string;
  toCity: string;
  time: Date;
  airplane: Airplane;
  sentEmails: number;
  seatsTaken: number;
  allEmailsSent: boolean;
}
