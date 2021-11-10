import { Injectable } from '@angular/core';
import { Product } from '../products';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  items: Product[] = [];
  constructor() { }

  /**
   * Appends a product to an array of items
   * @param product 
   */
  addToCart(product: Product) {
    this.items.push(product);
  }
  /**
   * Collects the items users add to the cart and return each item with its associated quantity.
   * @returns 
   */
  getItems() {
    return this.items;
  }
  /**
   * returns an empty array of items, wich empties the cart.
   * @returns 
   */
  clearCart() {
    this.items = [];
    return this.items;
  }
}
