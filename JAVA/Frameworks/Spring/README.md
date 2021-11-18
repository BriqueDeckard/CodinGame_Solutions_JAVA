# Notes : 

[source](https://gkemayo.developpez.com/tutoriels/java/tutoriel-sur-creation-application-web-avec-angular7-et-spring-boot-2/)  

## Annotations:

**Les différentes classes Java ci-dessus comportent plusieurs annotations :**

 ### Liées à Spring:   
  - **@Component**:
  Marque une classe en tant que Bean.

- **@Service**:  
Utilisée sur une classe qui effectue des traitements métiers.

- **@Controller**:
  Utilisée pour indiquer qu'une classe est un controller.
  
- **@ComponentScan**:
Indique a Spring qu'il doit scanner le package où se trouve cette classe pour y rechercher des composants Spring
  
 ### Liées à JPA: 
 - **@Repository**:
  Utilisée sur des classes qui accèdent la base de données.
  
-  **@Entity**:
Qui permet à hibernate/JPA de les considérer comme des ORM (Object Relational Mapping) devant transporter des données entre l'application et la base de données ;

-  **@Table**,
qui permet de mapper cet ORM sur une table physique en base de données ;

-  **@Id**,
qui permet de consacrer un attribut de la classe comme étant sa clef primaire ; et @GeneratedValue pour la stratégie de génération des valeurs de cette clef primaire ;

-  **@Column**,
pour le mapping d'un attribut de classe à une colonne de table en base de données ;

-  **@AssociationOverrides**, **@Embeddable** et **@EmbeddedId**,
pour la gestion de clef primaire composée et de migration de clef étrangère ;

-  **@ManyToOne**, **@OneToMany** et **@JoinColumn**,
pour la gestion des associations n-1, 1-n entre deux entités.


## DAO

Pour qu'une classe DAO de votre application soit prise en charge par le framework Spring Data JPA et considérée comme une couche d'accès aux données devant bénéficier de tous les services et facilités que propose ce dernier, elle devra respecter les conditions suivantes :

  

- être une **interface** Java ;

- porter l'annotation **@Repository**, pour permettre à Spring de l'injecter comme bean dans l'application;

- étendre l'une des interfaces suivantes : **Repository**, **CrudRepository**, **JpaRepository** ou **PagingAndSortingRepository**.

  

Le bout de code ci-dessous représente un exemple de classe Dao Spring Data JPA, nommée MyDao, dans laquelle T correspond à l'entité hibernate concernée par les requêtes dans cette classe et ID correspond au type de données de sa clef primaire :

  

```java

@Repository

public  interface  MyDao  extends  JpaRepository<T, ID> {

}

```

  

Lorsqu'une interface étend JpaRepository, elle hérite de toutes les fonctionnalités CRUD

(Create, Read, Update, Delete) que ce dernier fournit. On peut en citer quelques-unes : save(), saveAll(), delete(), deleteById(), deleteAll(), findById(), findAll(), exists(), existsById(), etc.

  

C'est alors Spring Data JPA qui se chargera de créer pour nous une classe d'implémentation de notre DAO.

  

## Spring Data JPA

Il existe un large panel de fonctionnalités que propose Spring Data JPA pour la gestion des données. Nous pensons que les plus immédiates que vous pourrez avoir besoin sont celles focalisées sur les opérations CRUD. Les fonctionnalités d'insertion (Create), de mise à jour (Update) et de suppression (Delete) ne posent en général pas de problème de variabilité dans leur utilisation. Ce qui n'est pas le cas pour la fonctionnalité de lecture (Read) de données en base où il existe plusieurs politiques. Nous nous arrêtons donc sur les trois politiques de lecture de données suivantes :

  

### 1. l'utilisation de l'annotation @NamedQuery pour la construction des requêtes nommées.

La requête nommée se marque sur l'entité concernée puis invoquée par la DAO à travers son nom.

#### Exemple :

  

**Declaration:**

```java
@Entity
@NamedQuery(name = "T.getAll", query = "select t from T t")
public  class  T {
	// ...
}
```

**Appel:**

```java
@Repository
public  interface  MyDao  extends  JpaRepository<T, ID> {
	/**
	 * Get all the entities
	 */
	public  List<T> getAll();
}
```  

### 2. l'utilisation de l'annotation @Query sur une méthode, directement dans la classe DAO.  

#### Exemple :  

**Appel:** 

```java

@Repository
public  interface  MyDao  extends  JpaRepository<T, ID> { 

	@Query(query = "select t from T t")
	public  List<T> getAll();
}
```

  

### 3. l'utilisation des méthodes prédéfinies ...

... qui doivent respecter un certain format afin de permettre à Spring Data JPA de générer la requête JPQL par déduction du nom de la méthode et de ses paramètres d'entrées.

  

#### Exemple :

**Appel:**  

```java

@Repository
public  interface  MyDao  extends  JpaRepository<T, ID> {  

	public  List<T> findAll();

	public  List<T> findByXxxAndYyyIgnoreCase(String  xXX, String  yYYY);

}

```  

## Services:

Les classes de services de notre application Library sont celles qui font directement appel aux DAO présentés précédemment, afin de récupérer les données, les traiter si nécessaire et les faire transiter vers les services de niveau supérieur qui en ont fait la demande (en l'occurrence les contrôleurs REST).

Il s'agit donc d'une classe intermédiaire entre la classe DAO et la classe Contrôleur qu'il faut implémenter afin de respecter la hiérarchie des appels dans une application de type SOA (Service Oriented Architecture).  

## Controllers:

Suite à la l'affichage de ces deux contrôleurs REST qui réalisent des opérations de création/modification/suppression/mise à jour d'un nouveau client/Prêts + l'envoi de mail à un client (CustomerRestController), vous remarquez qu'un bon nombre d'annotations Spring ont été utilisées. Elles sont possibles grâce au starter spring-boot-starter-web ajouté dans le pom.xl, qui à son tour injectera la dépendance Spring Webmvc correspondant à l'implémentation Spring d'API RESTful :  

- **@RestController** : permet de marquer une classe comme étant une qui exposera des ressources appelées web services ;

- **@RequestMapping** : permet de spécifier l'URI d'un web service ou d'une classe représentant le Contrôleur REST ;

- **@GetMapping** : marque une ressource (et donc un web service) comme accessible par la méthode GET de HTTP. Spécifie aussi l'URI de la ressource ;

- **@PostMapping** : marque une ressource comme accessible par la méthode POST de HTTP. Spécifie aussi l'URI de la ressource ;

- **@PutMapping** : marque une ressource comme accessible par la méthode PUT de HTTP. Spécifie aussi l'URI de la ressource ;

- **@DeleteMapping** : marque une ressource comme accessible par la méthode DELETE de HTTP. Spécifie aussi l'URI de la ressource.  

En appliquant les définitions données ci-dessus, nous observons que notre application Library expose :  

- pour le contrôleur CustomerRestController, sept web services représentés par les méthodes publiques suivantes : createNewCustomer, updateCustomer, deleteCustomer, searchCustomers, searchCustomerByEmail, searchBookByLastName, sendMailToCustomer ;

- pour le contrôleur LoanRestController, quatre web services représentés par les méthodes suivantes : searchAllBooksLoanBeforeThisDate, searchAllOpenedLoansOfThisCustomer, createNewLoan, closeLoan.

Ces contrôleurs REST s'appuient sur les classes de services (exemple : CustomerService, LoanService) présentées plus haut pour faire appel aux classes DAO afin d'accéder à la base de données H2.  

Dans les classes CustomerRestController et LoanRestController, nous avons utilisé d'autres annotations fournies par Spring qui concourent à la mise en place complète de web services. À savoir, @RequestBody, @RequestParam, @PathVariable qui sont les moyens de passage de paramètres du client vers le serveur.

Nous avons aussi utilisé l'objet ResponseEntity qui joue l'effet inverse permettant ainsi au serveur d'encapsuler les données qu'il renverra au client. Nous n'entrerons pas plus dans les détails, il existe de nombreux articles sur Internet qui s'étendent de long en large sur ces notions.

## JavaMailSender:

``` java
/**
 * Classe gerant l'envoi d'emails
 */
public class MailSender {

	@Autowired

	private JavaMailSender javaMailSender;
	
	/**
	 * Envoyer des emails a un compte.
	 */ 
	public void sendMail() throws MailException {

		//... créer ici l'objet message (de type SimpleMailMessage ou MimeMessage) à envoyer
		javaMailSender.send(message);
	}
}
```