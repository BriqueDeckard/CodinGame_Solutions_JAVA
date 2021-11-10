import { Component, OnInit } from '@angular/core';
// Allows to get data from a parent component 
import { Input } from '@angular/core';
// Allows to Pass data to a parent component
import { Output, EventEmitter } from '@angular/core';
import { Product } from '../products';
/**
 * Child component of ProductListComponent
 */
@Component({
  selector: 'app-product-alerts',
  templateUrl: './product-alerts.component.html',
  styleUrls: ['./product-alerts.component.css']
})
export class ProductAlertsComponent implements OnInit {

  /**
   * Get data from the parent component.
   */
  @Input() product!: Product;

  /**
   * Export data to the parent component.
   */
  @Output() notify = new EventEmitter();
  
  constructor() { }

  ngOnInit(): void {
  }

}
