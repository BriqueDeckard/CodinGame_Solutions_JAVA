package bd.notes.microservicearchitecture.customerservice.service;

import bd.notes.microservicearchitecture.customerservice.model.Customer;
import bd.notes.microservicearchitecture.customerservice.model.OrderList;
import bd.notes.microservicearchitecture.customerservice.model.PaymentList;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

@Service
public class CustomerService {
    /*
    The @Autowired annotation here injections the discovery
     client into the restTemplate variable. In other words,
      it contains the location of other microservices.
      Due to the discovery client injection, we are able
      to address the microservice by name when sending the
      HTTP request. For instance, instead of sending
      http://DOMAIN/PATH/TO/RESOURCE , we can simply use the
       name of the microservice as the domain.
     */
    @Autowired
    private RestTemplate restTemplate;

    public Customer getCustomerDetails() {
        OrderList orders = restTemplate.getForObject("http://order-service/api/order", OrderList.class);
        PaymentList payments = restTemplate.getForObject("http://payment-service/api/payment", PaymentList.class);
        return new Customer(0, orders, payments);
    }
}
