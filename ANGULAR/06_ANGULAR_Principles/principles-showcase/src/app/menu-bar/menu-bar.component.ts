import { Component, OnInit } from '@angular/core';
import { MatIconModule } from '@angular/material/icon'

@Component({
  selector: 'app-menu-bar',
  templateUrl: './menu-bar.component.html',
  styleUrls: ['./menu-bar.component.css']
})
export class MenuBarComponent implements OnInit {


  badgeContent = 6;

  links = { name:"show", link:"/show-object"}

  constructor() { }

  ngOnInit(): void {
  }

}
