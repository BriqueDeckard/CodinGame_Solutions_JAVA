package com.ecommerce.microcommerce.web.controller;

import com.ecommerce.microcommerce.dao.ProductDao;
import com.ecommerce.microcommerce.model.Product;
import com.ecommerce.microcommerce.web.exceptions.ProduitInrouvableException;
import com.fasterxml.jackson.databind.ser.FilterProvider;
import com.fasterxml.jackson.databind.ser.impl.SimpleBeanPropertyFilter;
import com.fasterxml.jackson.databind.ser.impl.SimpleFilterProvider;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.http.converter.json.MappingJacksonValue;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import javax.validation.Valid;
import java.net.URI;
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
@Api( description="API pour es opérations CRUD sur les produits.")
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
    @RequestMapping(value="/produits", method= RequestMethod.GET)
    public MappingJacksonValue listeProduits(){
        // get all the entities
        Iterable<Product> produits =  productDao.findAll();
        // create the filter
        /*
        SimpleBeanPropertyFilter est une implémentation de PropertyFilter qui permet d'établir les
         règles de filtrage sur un Bean donné. Ici, nous avons choisi la règle serializeAllExcept
         qui exclut uniquement les propriétés que nous souhaitons ignorer.
         Inversement, vous pouvez procéder avec la méthode filterOutAllExcept qui marque toutes
         les propriétés comme étant à ignorer sauf celles passées en argument.
         */
        SimpleBeanPropertyFilter monFiltre = SimpleBeanPropertyFilter.serializeAllExcept("prixAchat");
        // create the list of filters
        /*
        la ligne suivante nous permet d'indiquer à Jackson à quel Bean l'appliquer.
        Nous utilisons SimpleFilterProvider pour déclarer que les règles de filtrage que
        nous avons créées (monFiltre) peuvent s'appliquer à tous les Bean qui sont annotés
         avec monFiltreDynamique.
         */
        FilterProvider listeDeNosFiltres = new SimpleFilterProvider().addFilter("monFiltreDynamique", monFiltre);
        /*
        nous les mettons au format MappingJacksonValue. Cela permet de donner accès aux méthodes qui nous
        intéressent, comme setFilters qui applique les filtres que nous avons établis à la liste de Product.
         */
        MappingJacksonValue produitsFiltres = new MappingJacksonValue(produits);
        produitsFiltres.setFilters(listeDeNosFiltres);

        return produitsFiltres;
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

    @ApiOperation(value = "Récupère un produit grâce à son ID à condition que celui-ci soit en stock!")
    @GetMapping(value="/produits/{id}")
    public Product afficherUnProduit(@PathVariable int id){
        Product product = productDao.findById(id);
        if(product == null) throw new ProduitInrouvableException("Le produit avec l'id: " + id + " est introuvable");
        return product;
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
     *
     * ResponseEntity est une classe qui hérite de HttpEntity,  qui permet de définir le code HTTP  à retourner.
     * L'interêt de ResponseEntity est de nous donner la main pour personnaliser le code facilement.
     * @param product
     */
    @PostMapping(value = "/produits")
    public ResponseEntity<Void> ajouterProduit(@Valid @RequestBody Product product){
        // Add the product
        Product productAdded = productDao.save(product);
        // Check if the product has been added
        if(productAdded == null){
            // If not, return 204 - No Content
            return ResponseEntity
                    .noContent()
                    // build() construit le header et y ajoute le code choisi.
                    .build();
        }
        // else return 201 with the URI
        URI location = ServletUriComponentsBuilder
                .fromCurrentRequest()
                .path("/{id}")
                .buildAndExpand(productAdded.getId())
                .toUri();
        return ResponseEntity.created(location).build();
    }

    @GetMapping(value = "test/produits/{prixLimit}")
    public List<Product> testeDeRequetes(@PathVariable int prixLimit) {
        return productDao.findByPrixGreaterThan(400);
    }

    @GetMapping(value = "test/produits/{recherche}")
    public List<Product> testeDeRequetes(@PathVariable String recherche) {
        return productDao.findByNomLike("%"+recherche+"%");
    }

    @DeleteMapping (value = "/produits/{id}")
    public void supprimerProduit(@PathVariable int id) {
        productDao.deleteById(id);
    }

    @PutMapping (value = "/produits")
    public void updateProduit(@RequestBody Product product) {

        productDao.save(product);
    }
}
