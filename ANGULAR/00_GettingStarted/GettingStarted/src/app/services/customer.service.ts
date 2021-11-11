import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../models/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(
    private http: HttpClient
  ) { }

  getCustomersList() {
    return this.http.get<Customer[]>(`http://localhost:8080/rest/customer/api/getAllCustomers`);
  }

}
