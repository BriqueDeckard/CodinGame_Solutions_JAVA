# Notes on microservices

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