import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { TopBarComponent } from './top-bar/top-bar.component';
import { ProductListComponent } from './product-list/product-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProductAlertsComponent } from './product-alerts/product-alerts.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { CartComponent } from './cart/cart.component';
import { ShippingComponent } from './shipping/shipping.component';
import { BooksComponent } from './books/books.component';
import { CustomerComponent } from './customer/customer.component';

@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      // Root route
      { path: '', component: ProductListComponent },
      // Product route
      { path: 'products/:productId', component: ProductDetailsComponent },
      // Cart route
      { path: 'cart', component: CartComponent },
      // Shipping route
      { path: 'shipping', component: ShippingComponent },
      // Books route
      { path: 'books', component: BooksComponent },
      // Customer route
      { path: 'customers', component: CustomerComponent }
    ]),
    BrowserAnimationsModule
  ],
  declarations: [
    AppComponent,
    TopBarComponent,
    ProductListComponent,
    ProductAlertsComponent,
    ProductDetailsComponent,
    CartComponent,
    ShippingComponent,
    BooksComponent,
    CustomerComponent
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
