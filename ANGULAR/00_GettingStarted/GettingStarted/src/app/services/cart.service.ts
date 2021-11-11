import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from '../products';
import { stringify } from 'querystring';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  items: Product[] = [];
  constructor(
    private http: HttpClient
  ) { }

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

  getShippingPrices() {
    return this.http.get<{ type: string, price: number }[]>('/assets/shipping.json');
  }
}
