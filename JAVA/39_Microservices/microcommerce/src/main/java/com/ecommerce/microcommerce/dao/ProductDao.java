package com.ecommerce.microcommerce.dao;

import com.ecommerce.microcommerce.model.Product;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;
@Repository
public interface ProductDao extends JpaRepository<Product, Integer>{
 Product findById(int id);

 /**
  * Toute la logique est fournie par le nom de la méthode !
  *
  * findBy : indique que l'opération à exécuter est un SELECT ;
  *
  * Prix : fournit le nom de la propriété sur laquelle le SELECT s'applique
  *
  * GreaterThan : définit une condition "plus grand que"
  * @param prixLimit
  * @return
  */
 List<Product> findByPrixGreaterThan(int prixLimit);

 /**
  * findBy : indique que l'opération à exécuter est un SELECT ;
  * Nom : fournit le nom de la propriété sur laquelle le select s'applique
  * like : definit une condition "est egal a "
  * @param recherche
  * @return
  */
 List<Product> findByNomLike(String recherche);

 @Query("SELECT id, nom, prix FROM Product p WHERE p.prix > :prixLimit")
 List<Product>  chercherUnProduitCher(@Param("prixLimit") int prix);
}
