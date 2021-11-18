package bd.notes.microservicearchitecture.orderservice.service;

import bd.notes.microservicearchitecture.orderservice.model.Order;
import bd.notes.microservicearchitecture.orderservice.model.OrderList;
import org.springframework.stereotype.Service;

import java.util.Arrays;
import java.util.List;

@Service
public class OrderService {

    public OrderList getAllOrders() {
        List<Order> list = Arrays.asList(
                new Order(0, 100.50),
                new Order(1, 50.20),
                new Order(2, 30.10),
                new Order(3, 15),
                new Order(4, 200.90)
        );
        OrderList orderList = new OrderList(list);
        return orderList;
    }
}
