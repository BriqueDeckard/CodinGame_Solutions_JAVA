# LibraryUi

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 7.3.3.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).

## Notes :

### Creation: 

```
ng new Library-ui
```
### Configuration: 

#### Routage du point d'entrée : 

Lors de la phase de développement, le framework Angular utilise le port 4200 sur votre localhost pour visualiser en temps réel les IHM développées. L’URL d'accès est donc la suivante : http://localhost:4200.
Nous voulons par ailleurs que notre application soit accessible via le lien http://localhost:4200/library-ui où library-ui est le point d'entrée de l'application permettant d'afficher le menu. configurer. Enfin, et comme nous l'avons expliqué, notre application Library-ui communiquera avec le back-end à l'aide d'appel REST. Il est donc important que nous vous présentions comment cela est mis en place.

#### 1. Modification du fichier Package.json

Dans le répertoire d'installation du projet Library-ui (voir capture ci-dessus), ouvrez le fichier Package.json et modifiez la ligne

```
start
```
pour ajouter l'instruction suivante : 
```
--base-href /library-ui --proxy-config proxy.conf.json.
```

- La commande --base-href /library-ui, permet de marquer l'accessibilité de la page web principale sur le suffixe /library-ui. Exemple : la saisie de l’URL http://localhost:4200/library-ui permettra d'afficher le menu principal.
- La commande --proxy-config proxy-conf.json, permet d'indiquer l'adresse des différents serveurs côté back-end auxquels l'application cliente Angular peut être amenée à appeler. En d'autres termes, c'est dans ce fichier que l'on configure les URL des serveurs qui hébergent les API REST auxquels Library-ui va faire appel.

#### 2. Création du fichier proxy-conf.json

Dans le répertoire d'installation du projet Library-ui (voir capture ci-dessus) et au même niveau que le fichier package.json, créez le fichier de nom proxy-conf.json et ajoutez y le code suivant : 

```json
{
    "/library/": {
        "target": "http://localhost:8082",
        "secure": "false"
    }
}
```

le contenu de ce fichier indique que le serveur back-end répond sur l'URL http://localhost:8082 en n'admettant uniquement les requêtes http contenant le préfixe /library. Cette configuration s'adapte donc aux URI de nos API REST exposés dans le projet Library côté back-end dans les contrôleurs REST.

