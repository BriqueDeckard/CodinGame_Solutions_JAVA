# ANGULAR:

Angular is an application design framework and development platform for creating efficient and sophisticated single-page apps.

## Notes:

### Commands

New project:

```
ng new name-of-the-project
```
New component:

```
ng g c name-of-the-component
```

Run a project:

```
ng serve -o
```

npm install --save --legacy-peer-deps: 
--> [LINK](https://stackoverflow.com/questions/66239691/what-does-npm-install-legacy-peer-deps-do-exactly-when-is-it-recommended-wh)
```
npm install --save --legacy-peer-deps
```

### Code:

#### *ngFor:

With *ngFor, the ```<div>``` repeats for each product in the list.

```
*ngFor="let product of products"
```

#### Interpolation: 

 Interpolation ```{{ }}``` lets you render the property value as text.

```
{{ product.name }}
```
