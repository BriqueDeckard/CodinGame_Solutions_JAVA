import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../models/customer';

@Injectable({
    providedIn: 'root'
})
export class CustomerService {
    constructor(private http: HttpClient) { }

    /**
     * Save a new Customer object in the Backend Server data base.
     */
    saveCustomer(customer: Customer): Observable<Customer> {
        return this.http.post<Customer>('/library/rest/customer/api/addCustomer', customer);
    }

    /**
     * Update aCustomer object in the backend server database.
     * @param customer 
     * @returns 
     */
    updateCustomer(customer: Customer): Observable<Customer> {
        return this.http.put<Customer>('/library/rest/customer/api/updateCustomer', customer);
    }

    /**
     * Delete an existing customer object in the backend server data base.
     * @param customer 
     * @returns 
     */
    deleteCustomer(customer: Customer): Observable<string> {
        return this.http.delete<string>('/library/rest/customer/api/deleteCustomer/' + customer.id);
    }

    /**
     * Search a customer by its email.
     * @param email 
     * @returns 
     */
    searchCustomerByEmail(email: string): Observable<Customer> {
        return this.http.get<Customer>('/library/rest/customer/api/searchByEmail?email=' + email);
    }
    /**
     * Search all customer named by this last name.
     * @param lastName 
     * @returns 
     */
    searchCustomerByLastName(lastName: string): Observable<Customer[]> {
        return this.http.get<Customer[]>('/library/rest/customer/api/searchByLastName?lastName=' + lastName);
    }
}