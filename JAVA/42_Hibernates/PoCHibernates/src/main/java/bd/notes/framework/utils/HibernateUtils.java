package bd.notes.framework.utils;

import org.hibernate.SessionFactory;
import org.hibernate.boot.Metadata;
import org.hibernate.boot.MetadataSources;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;
import org.hibernate.service.ServiceRegistry;

/**
 * HibernateUtils is a utility class, it has a method to return the SessionFactory object.
 */
public class HibernateUtils {
    private static final SessionFactory sessionFactory = buildSessionFactory();


    private static SessionFactory buildSessionFactory() {
        try {
            // Create the ServiceRegistry from hibernate.cfg.xml
            ServiceRegistry serviceRegistry = new StandardServiceRegistryBuilder()//
                    .configure().build();
            // Create the metadata sources using the specified service registry
            Metadata metadata = new MetadataSources(serviceRegistry).getMetadataBuilder().build();
            // return the built session factory
            return metadata.getSessionFactoryBuilder().build();
        } catch (Throwable ex) {
            System.err.println("Initial session factory creation failed: " + ex);
            throw new ExceptionInInitializerError(ex);
        }
    }

    public static SessionFactory getSessionFactory() {
        return sessionFactory;
    }

    public static void shutdown() {
        // Closes caches and connection pools.
        getSessionFactory().close();
    }

}
