package com.ecommerce.microcommerce.dao;

import com.ecommerce.microcommerce.model.Product;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

/**
 * isolate the application/business layer from the persistence layer (usually a relational database, but it could
 * be any other persistence mechanism) using an abstract API.
 *
 * - JpaRepository is JPA specific extension of Repository. It contains the full API of CrudRepository and
 * PagingAndSortingRepository. So it contains API for basic CRUD operations and also API for pagination and sorting.
 *
 * - The Spring @Repository annotation is a specialization of the @Component annotation which indicates that an
 * annotated class is a “Repository”, which can be used as a mechanism for encapsulating storage, retrieval,
 * and search behavior which emulates a collection of objects
 *
 * JpaRepository<TEntity,TID>
 */
@Repository
public interface ProductDao extends JpaRepository<Product, Integer>{
 Product findById(int id);

 /**
  * All the logic is provided by the name of the method
  *
  * - findBy : indicates that the process to run is a SELECT ;
  * - Prix : provides the name of the property on which the SELECT
  * is applied
  * - GreaterThan : defines a "greater than" condition
  * @param prixLimit
  * @return
  */
 List<Product> findByPrixGreaterThan(int prixLimit);

 /**
  * - findBy : indicates that the process to run is a SELECT ;
  * - Nom : provides the name of the property on which the SELECT
  * is applied
  * like : define a "is equal to" condition
  * @param recherche
  * @return
  */
 List<Product> findByNomLike(String recherche);

 /**
  * Custom query that cannot be defines by the word of the method
  *
  * @param prix
  * @return
  */
 @Query("SELECT id, nom, prix FROM Product p WHERE p.prix > :prixLimit")
 List<Product>  chercherUnProduitCher(@Param("prixLimit") int prix);
}
