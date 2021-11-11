import { Component } from '@angular/core';

import { products } from '../models/products';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
  /**
   * products property that contains imported data for each product from the products array in products.ts
   */
  products = products;

  share() {
    window.alert('ProductListComponent: The product has been shared!');
  }

  onNotify(){
    window.alert('You will be notified when the product goes on sale');
  }
}