package bd.notes.microservicearchitecture.paymentservice.controller;

import bd.notes.microservicearchitecture.paymentservice.model.PaymentList;
import bd.notes.microservicearchitecture.paymentservice.service.PaymentService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class PaymentController {
    @Autowired
    private PaymentService paymentService;

    @GetMapping("/api/payment")
    public PaymentList getAllPayments() {
        return paymentService.getAllPayments();
    }
}
