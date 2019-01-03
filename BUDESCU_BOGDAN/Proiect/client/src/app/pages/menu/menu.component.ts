import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {

  constructor() { }

  ngOnChanges(changes: SimpleChanges): void {
    //Called before any other lifecycle hook. Use it to inject dependencies, but avoid any serious work here.
    //Add '${implements OnChanges}' to the class.

  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.

  }

  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.

  }

  ngOnDestroy(): void {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.

  }

  public expandMenu(): void {

    let navbar: HTMLElement = document.getElementById("navbarResponsive");
    let isExpanded: boolean = navbar.style.display != "none" ;
    if (isExpanded) {
      navbar.style.display = "none";
    } else {
      navbar.style.display = "block";
    }
  }

  public closeExpandedMenu() {
    
    let navbar: HTMLElement = document.getElementById("navbarResponsive");
    navbar.style.display = "none" 
  }
}
