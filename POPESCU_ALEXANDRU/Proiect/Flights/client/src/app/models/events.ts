import {User} from "./user";

export class Events {
  id: number;
  user: User;
  type: string;
  details: string;
  timestamp: Date;
}
