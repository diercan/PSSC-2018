import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  public languageData = require("./app_ro.json")
  constructor() { 

    this.changeLanguage("ro");
    this.changeLanguage("en")

  }

  public changeLanguage(language) {

    console.log(language)
    this.languageData = require("./app_" + language + ".json");
  }
}
