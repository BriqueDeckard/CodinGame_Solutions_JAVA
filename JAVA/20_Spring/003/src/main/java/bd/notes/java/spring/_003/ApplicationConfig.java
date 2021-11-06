package bd.notes.java.spring._003;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

/**
 * Ce fichier de configuration sert a creer des beans pour servir le contexte de l'application.
 */
@Configuration
public class ApplicationConfig {

    @Autowired
    private A a;

    @Autowired
    private B b;

    @Bean
    public A a() {
        return new A();
    }

    @Bean
    public B b() {
        return new B();
    }

    @Bean
    public C c() {
        return new C(a, b);
    }
}
