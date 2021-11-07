# Notes :
## Annotations: 
**Les différentes classes Java ci-dessus comportent plusieurs annotations :**

- **@Entity**:

Qui permet à hibernate/JPA de les considérer comme des ORM (Object Relational Mapping) devant transporter des données entre l'application et la base de données ;
- **@Table**, 

qui permet de mapper cet ORM sur une table physique en base de données ;
- **@Id**, 

qui permet de consacrer un attribut de la classe comme étant sa clef primaire ; et @GeneratedValue pour la stratégie de génération des valeurs de cette clef primaire ;
- **@Column**, 

pour le mapping d'un attribut de classe à une colonne de table en base de données ;
- **@AssociationOverrides**, **@Embeddable** et **@EmbeddedId**, 

pour la gestion de clef primaire composée et de migration de clef étrangère ;
- **@ManyToOne**, **@OneToMany** et **@JoinColumn**, 

pour la gestion des associations n-1, 1-n entre deux entités.

## DAO
Pour qu'une classe DAO de votre application soit prise en charge par le framework Spring Data JPA et considérée comme une couche d'accès aux données devant bénéficier de tous les services et facilités que propose ce dernier, elle devra respecter les conditions suivantes :

- être une **interface** Java ;
- porter l'annotation **@Repository**, pour permettre à Spring de l'injecter comme bean dans l'application;
- étendre l'une des interfaces suivantes : **Repository**, **CrudRepository**, **JpaRepository** ou **PagingAndSortingRepository**.

Le bout de code ci-dessous représente un exemple de classe Dao Spring Data JPA, nommée MyDao, dans laquelle T correspond à l'entité hibernate concernée par les requêtes dans cette classe et ID correspond au type de données de sa clef primaire :

```java
@Repository
public interface MyDao extends JpaRepository<T, ID> {
    
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
public class T {
}
```
**Appel:**

```java
@Repository        
public interface MyDao extends JpaRepository<T, ID> {
    public List<T> getAll();
}
```

### 2. l'utilisation de l'annotation @Query sur une méthode, directement dans la classe DAO. 

#### Exemple :

**Appel:**

```java
@Repository                
public interface MyDao extends JpaRepository<T, ID> {

    @Query(query = "select t from T t")    
    public List<T> getAll();
}
```

### 3. l'utilisation des méthodes prédéfinies qui doivent respecter un certain format afin de permettre à Spring Data JPA de générer la requête JPQL par déduction du nom de la méthode et de ses paramètres d'entrées. 

#### Exemple :
**Appel:**

```java
@Repository                
public interface MyDao extends JpaRepository<T, ID> {

    public List<T> findAll();
    public List<T> findByXxxAndYyyIgnoreCase(String xXX, String yYYY);
    
}
```