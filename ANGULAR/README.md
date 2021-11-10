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
***The generator automatically added the component to the AppModule to make it available to other components in the application.***


Run a project:

```
ng serve -o
```

npm install --save --legacy-peer-deps: 
--> [LINK](https://stackoverflow.com/questions/66239691/what-does-npm-install-legacy-peer-deps-do-exactly-when-is-it-recommended-wh)
```
npm install --save --legacy-peer-deps
```

### In the template.html:
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

#### @Component:

```
@Component({ ... })
```

The @Component() definition also exports the class, ProductAlertsComponent, which handles functionality for the component.

### In the component.ts:

#### The selector: 

```
selector: 'app-product-alerts',
```

The selector, ```app-product-alerts```, identifies the component. 
By convention, Angular component selectors begin with the prefix ```app-```, followed by the component name.

#### The template:

```
templateUrl: './product-alerts.component.html',
```

The template and style filenames reference the component's HTML and CSS.

#### @Input & @Output

- ```@Input()``` allows the Component to get data from its parent Component.
- ```@Output()``` allows the Component to emit an event when the value of the notify property changes.

 The parent acts when the child raises the event.

## Routing:

You can add a route in ```app.module.ts```
Like this : ```{ path: 'route/:entityId', component: NameOfTheComponent },```

## Links:

- [Pass data to a child component](https://angular.io/start#pass-data-to-a-child-component)
- [Pass data to a parent component](https://angular.io/start#pass-data-to-a-parent-component)