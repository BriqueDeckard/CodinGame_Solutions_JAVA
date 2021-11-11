import { Component, OnInit } from '@angular/core';
import { Customer } from '../models/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  customers: Customer[] | undefined;

  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
    this.customerService.getCustomersList().subscribe(
      (data) => {
        this.customers = data;
      });
  }
}
