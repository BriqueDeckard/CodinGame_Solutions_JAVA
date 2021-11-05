# JSON WEB TOKEN:

Standard qui permet l'échange sécurisé de jetons. Ce système garantit l'intégrité et l'authenticité des jetons.

- Header: JSon qui décrit l'objet
- Payload: Infos embarqués dans le jeton
- Signature

Pour Java --> Java JWT

## Avantage: 
- le JWT contient toutes les données importantes. Il n'est plus necessaire de consulter une DB, le serveur peut être stateless.
- Le JWT contient des informations sûres sur l'identité de l'expediteur et sur ses droits d'accès.

## Fonctionnement:
1. Une clé secrete est déterminée avant la creation du JWT
2. L'utilisateur se log avec succès. Le JWT est renvoyé à l'utilisateur et stocké localement. (il est transferé en HTTPS)
3. Lorsque l'utilisateur veut acceder a des ressources, le JWT est envoyé en paramètre ou en header de la requête. L'interlocuteur peut déchiffrer le JWT et si le contrôle est reussi, executer la commande.

## Avec REST:
Le JWT sécurise le protocole stateless, puisque les infos sont dans la requête.
## Avec Cross Origin Ressource Sharing: 
le JWT envoie les infos
## Avec de multiples frameworks:
Le JWT, etant standardisé, permet de partager des données d'authent entre les frameworks