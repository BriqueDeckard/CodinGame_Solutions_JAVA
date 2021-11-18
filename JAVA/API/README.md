# Api REST : 

## RESTful ?
Pour considérer qu’une API est RESTful, 6 contraintes ont été proposées par Roy Fielding:

1.  **Client-Server** – Un mode de communication avec séparation de rôles entre client et serveur.
2.  **Stateless Server** – Les requêtes doivent contenir toutes les informations nécessaires au traitement. Il ne doit pas y avoir une notion de session côté serveur. Cette contrainte est indispensable pour rendre une API scalable.
3.  **Cache** – La réponse du serveur doit être cacheable côté client.
4.  **Uniform interface** – La méthode de communication entre client et serveur doit être uniforme avec des ressources identifiables, représentables et auto-descriptives. Autrement dit, en vocabulaire HTTP, avec une URL et une réponse contenant un body et une entête.
5.  **Layered System** – Le système doit permettre le rajout de couches intermédiaires _(proxy server, firewall, CDN, etc …)_.
6.  **Code-on-Demand Architecture (optionnelle)** – L’architecture doit permettre d’exécuter du code côté client.

## LES IDENTIFIANTS DE RESSOURCE

**REST** est une architecture orientée ressources où chaque ressource est accessible via un identifiant unique _(URI)_.

## LES CODES RETOUR HTTP D’API REST

![Illus_API_REST](Illu_API_REST_1.png)