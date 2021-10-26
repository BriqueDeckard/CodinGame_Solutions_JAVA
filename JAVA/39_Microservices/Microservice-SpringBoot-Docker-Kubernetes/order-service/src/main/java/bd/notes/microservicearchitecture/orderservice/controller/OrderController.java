package bd.notes.microservicearchitecture.orderservice.controller;

import bd.notes.microservicearchitecture.orderservice.model.OrderList;
import bd.notes.microservicearchitecture.orderservice.service.OrderService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class OrderController {

    @Autowired
    private OrderService orderService;

    @GetMapping("/api/order")
    public OrderList getAllOrders(){
        return orderService.getAllOrders();
    }
}
