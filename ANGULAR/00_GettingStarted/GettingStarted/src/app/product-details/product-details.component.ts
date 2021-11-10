import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product, products } from '../products';
import { CartService } from '../services/cart.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {

  product: Product | undefined

  constructor(
    private route: ActivatedRoute,
    private cartService: CartService
  ) { }

  /**
   * Takes the current product as an argument
   * Uses the CartService addToCart method
   * @param product 
   */
  addToCart(product: Product) {
    this.cartService.addToCart(product);
    window.alert('Your ptoduct has been added to the cart!');
  }

  ngOnInit() {
    // First, get the product ID from the current route
    const routeParams = this.route.snapshot.paramMap;
    const ProductIdFromRoute = Number(routeParams.get('productId'));

    // Find the product that correspond with the id provided in route.
    this.product = products.find(product => product.id === ProductIdFromRoute)
  }

}
