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
 * @Controller annotation from Sprign allow to specify a class as a
 * controller, giving it the ability to treat GET, POST, ... queries
 * We then apply "@ResponseBody" on the methods that will have to
 * answer directly without passing by the view.
 *
 * @RestController is simply the combination of @Controller and @ResponseBody
 * One added, it indicates that this class will process
 * queries that we will define.
 * It also indicates that each method will send directly the JSON answer
 * to the uuser
 */
@Api( description="API pour es opérations CRUD sur les produits.")
@RestController
public class ProductController {

    // Autowired allows injection (like 'ejb')
    @Autowired
    private ProductDao productDao;
    /**
     *  @RequestMapping allows to make the link between
     *  the URI "/Produits", invoked via the GET,
     *  and the listeProduits method
     * @return
     */
    @RequestMapping(value="/produits", method= RequestMethod.GET)
    public MappingJacksonValue listeProduits(){
        // get all the entities
        Iterable<Product> produits =  productDao.findAll();
        // create the filter
        /*
        SimpleBeanPropertyFilter is an implementation of PropertyFilter that allows
         to establish the filtering rules for a given bean.
          Her, we have chose the 'serializeAllExcept' rule, that only exclude
          the property that we wish to ignore.
          Inversely, you can proceed with filterOutAllExcept that
          marks all the properties as "to ignore", exceppt those
           passed as arguments.
         */
        SimpleBeanPropertyFilter monFiltre = SimpleBeanPropertyFilter.serializeAllExcept("prixAchat");
        // create the list of filters
        /*
        The following line allows us to indicate to Jackson to which bean
        apply the filter.
        We uuse SimpleFilterProvider to declare that the filtering rules
         that we have created  (monFiltre) can be applied to all the beans
          that are annotated with "monFiltreDynamique".
         */
        FilterProvider listeDeNosFiltres = new SimpleFilterProvider().addFilter("monFiltreDynamique", monFiltre);
        /*
        We format it to "MappingJacksonValue"
        This allows to give access to the methods that interest us.
         Like  setFilters that applying filters to the product list.
         */
        MappingJacksonValue produitsFiltres = new MappingJacksonValue(produits);
        produitsFiltres.setFilters(listeDeNosFiltres);

        return produitsFiltres;
    }

    /**
     * {id} adding to the URI.
     * This notation indicates that this method must only answer
     * to queries presenting an URI like  /Produits/25 for example.
     * id must be an int ( @PathVariable int id)
     * @param id
     * @return
     */
    // @GetMapping(value="/Produits/{id}")
    // Is equal to :
    // @RequestMapping(value = "/Produits/{id}", method = RequestMethod.GET)

    @ApiOperation(value = "Gets a product by its ID " +
            "if it is in the stock!")
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
        return ResponseEntity.crea0ted(location).build();
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
