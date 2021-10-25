package bd.notes.microservicearchitecture.customerservice.controller;

import bd.notes.microservicearchitecture.customerservice.model.Customer;
import bd.notes.microservicearchitecture.customerservice.service.CustomerService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CustomerController {
    @Autowired
    private CustomerService customerService;

    @GetMapping("/api/customer")
    public Customer getCustomerDetails(){
        return customerService.getCustomerDetails();
    }
}
