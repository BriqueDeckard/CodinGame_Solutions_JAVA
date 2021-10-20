package com.ecommerce.microcommerce.web.controller;

import com.ecommerce.microcommerce.dao.ProductDao;
import com.ecommerce.microcommerce.model.Product;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

/**
 * l'annotation @Controller de Spring
 * permet de désigner une classe comme contrôleur, lui conférant
 * la capacité de traiter les requêtes de type GET, POST, etc.
 * ensuite @ResponseBody sur les méthodes qui devront
 * répondre directement sans passer par une vue.
 *
 * @RestController est simplement la combinaison des deux annotations
 * précédentes. Une fois ajouté, il indique que cette classe va
 * pouvoir traiter les requêtes que nous allons définir. Il indique
 * aussi que chaque méthode va renvoyer directement la réponse
 * JSON à l'utilisateur, donc pas de vue dans le circuit.
 */
@RestController
public class ProductController {

    // Autowired allow injection
    @Autowired
    private ProductDao productDao;
    /**
     *  @RequestMapping permet de faire le lien entre
     *  l'URI "/Produits", invoquée via GET,
     *  et la méthode listeProduits
     * @return
     */
    @RequestMapping(value="/Produits", method= RequestMethod.GET)
    public List<Product> listeProduits(){
        return productDao.findAll();
    }

    /**
     * ajout de {id} à l'URI. Cette notation permet d'indiquer
     * que cette méthode doit répondre uniquement aux requêtes
     * avec une URI de type /Produits/25 par exemple.
     * id doit être un int (dans @PathVariable int id)
     * @param id
     * @return
     */
    // @GetMapping(value="/Produits/{id}")
    // Is equal to :
    // @RequestMapping(value = "/Produits/{id}", method = RequestMethod.GET)
    @GetMapping(value="/Produits/{id}")
    public Product afficherUnProduit(@PathVariable int id){
        return  productDao.findById(id);
    }

    /**
     * Nous allons recevoir une requête POST avec les informations d'un nouveau produit au format JSON.
     * Il nous faut donc constituer un objet Product à partir de ce JSON.
     *
     * Cette annotation demande à Spring que le JSON contenu dans la partie body de la requête HTTP
     * soit converti en objet Java. Comment ?  Spring, qui a déjà tout auto-configuré au début, ira
     * simplement chercher la librairie capable de faire cela et l'utiliser. Dans notre cas c'est
     * Jackson, mais cela pourrait tout à fait être Gson.
     *
     * La requête JSON est ainsi convertie, dans notre cas, en objet Product puis passée en paramètre
     * à ajouterProduit.
     * @param product
     */
    @PostMapping(value = "/produits")
    public void ajouterProduit(@RequestBody Product product){
        productDao.save(product);
    }
}
