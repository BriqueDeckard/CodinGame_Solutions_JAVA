# Notes on microservices

[Talend](https://www.talend.com/fr/resources/guide-microservices/)

## Problematic

1. Availability : available all the time
2. Scalability : able to span more resources and to evolve
3. Updatability : the company must be able to evolve its application frequently

## Pro / cons:
### Avantages:
- Decompose ce qui serait autrement une application monilithique en un ensemble plus gérable de services aux limites bien définies. Les services peuvent être de technologies differentes, développées, maintenu et modifiés individuellements et facilement.
- Rend le déploiement continu possible : Les mises a jour et nouvelle fonctionnalités peuvent être poussées individuellement puisque les services peuvent être déployés de manière indépendante. 
- Le dimensionnement est facilité et optimisé, ce qui n'est pas toujours le cas avec une application monoloithique. Les microservices permettent d'isoler les fonctions saturées et de les scaler de manière horizontale. De la même manière, les organismes peuvent ne déployer que le nombre d'instance dont ils ont besoin, en mobilisant le matériel qui correspond le mieux aux besoins.
### Inconvénients:
- Complexité
- Temps de développement
- le terme micro est relatif. Les blocs ne doivent ni etre trop grands, ni trop petits. L'équilibre "parfait" peut être dur à trouver
- Plusieurs bases de données cloisonnées == potentiels mises à jour compliquées
- Les changements peuvent être compliqués si les services présentent de nombreuses dépendances. Les développeurs doivent soigneusement planifier et coordonner les déploiements.
- Nouvelles responsabilités, gestion potentiellement plus complexe.Découverte de service, load balancer, cache et routage de la couche 7 (application)
## Principle

The microservice architecture proposes to divide an application into small services, called "microservices", fully self-contained services that expose a REST API that other microservices can consume.

<details>
	<summary>
		Notes : 
	</summary>
	<ul>
		<li>Restcontroller: ```@RestController```</li>
		<li>Get: ```@GetMapping("/route")```</li>
	</ul>
</details>

Methode pour concevoir une application comme un ensemble de services modulaires à la granularité assez fine. Chaque module répond à un objectif métier spécifique et communique avec les autres modules via, eventullement via une api (API REST, SOAP, AMQP et JMS.).

## Les microservices devraient respecter les lignes directrices suivantes :

- **Base de codes** :
 
> Chaque microservice a besoin d'une base de codes unique qui est suivie dans le contrôle de révision. Les microservices ne doivent pas partager de bases de codes.

- **Dépendances** : 
 
> Chaque microservice doit déclarer, isoler et emballer explicitement ses dépendances.

- **Configuration** : 

> la configuration de l'application (par exemple, les informations d'identification) peut changer entre les déploiements. Stockez ces données de configuration en dehors du microservice, de sorte que le microservice utilise la configuration appropriée propre à l'environnement de déploiement.

- **Services de support** : 

> Les clients doivent consommer des microservices via des URL sur le réseau, et les microservices ne doivent pas faire de distinction entre les services locaux et les services tiers.

- **Créer, libérer et exécuter** : 

> traitez chaque étape du processus de développement et de déploiement d'applications comme une étape distincte. Au stade de la construction, le code est traduit en un groupe exécutable (build). Au cours de la phase de version, la construction se combine à la configuration actuelle du déploiement (développement, test, préparation ou production). Lors de l'exécution, l'application s'exécute dans l'environnement d'exécution par rapport à la version sélectionnée.

- **Processus** : 

> Les microservices sont apatrides et suivent le modèle de partage. L'état n'existe que dans un cache externe ou une banque de données.

- **Liaison de port** : 
> un microservice s'exécute dans un conteneur et expose toutes ses interfaces via des ports qui écoutent les demandes.

- **Concurrence** : 
> un processus de microservice s'adapte pour répondre à une demande plus élevée en ajoutant des copies en cours d'exécution du microservice. Un moteur d'orchestration de conteneurs peut vous aider dans ce processus.

- **Disposabilité** : 
> Les processus de microservice peuvent être démarrés ou arrêtés immédiatement chaque fois que nécessaire.

- **Parité de développement et de production** : 
> Maintenir les environnements de développement et de production aussi semblables que possible.

- **Journaux** : 
> les journaux sont gérés en tant que flux d'événements. Un microservice écrit des journaux dans son flux d'événements, qui est ordonné par le temps et non rempli. Le microservice ne doit jamais gérer le routage ou le stockage de son flux de sortie, et il ne doit pas gérer les fichiers journaux.

- **Processus d'administration** : 
> les tâches de maintenance et d'administration doivent être exécutées en tant que processus ponctuels (par exemple, migration de base de données) sur un environnement identique à celui des microservices.
