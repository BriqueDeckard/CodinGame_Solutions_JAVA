/**
 * Salut Iscia. 
 * 
 * Désolé, c'est un peu le bordel ce script, mais j'ai voulu tout faire tenir sur un
 * ou deux fichiers, et t'expliquer le plus de trucs possible.
 * 
 * On commence par MongoDB, la création d'une base, l'ajout de quelques trucs dans cette base
 * et la récupération de ces trucs.
 * 
 * Ensuite, on passe à Express
 * 
 * Ensuite il y a le 'routage'
 * 
 * Il y a beaucoup de texte, mais c'ests urtout des commentaires. Pour ecrire une api, tu n'as 
 * pas besoin de beaucoup de code.
 * 
 * 1. PREPARATION
 * 1.1. MongoDB:
 * 
 * Déjà, il faut avoir MongoDb d'installé;
 * --> https://www.mongodb.com/try/download/community
 * 
 * Là, il te faut une base de données.
 * Tu ouvre l'invité de commande :
 * 
       Windows + R ;
 * 
 * Dedans, tu et tape "cmd" pour ouvrir une console.
 * 
 * Depuis cette console, tu vas dans le dossier d'installation de MongoDb.
 * Ca doit etre quelque chose du genre :
 *    
      E:\Program Files\MongoDB\Server\5.0\bin
 * 
 * Pour changer de dossier, tu tape : 
 * 
       cd chemin\du\dossier
 * 
 * par exemple: 
 * 
       cd E:\Program Files\MongoDB\Server\5.0\bin
 * 
 * Une fois que tu es dans ce dossier depuis la console, tu tape "mongo.exe"
 * Normalement, ça va t'afficher du texte, puis ton "pointeur" (où tu tape)
 * va devenir ">"
 * 
 * Là, tu peux taper "db" pour lister les bases qui existent.
 * 
 * On va créer une base. Tu tape (toujours dans la console après le ">") :
 * 
      use things
 * 
 * Ca devrait t'afficher 'switched to db things'
 * 
 * Pour insérer des données, ça se fait comme ça :
 * 
 *     
        db.peoples.insert({
                           identifiant:1,
                            nom:"Bob",
                            age:45
                         })
                         
 * Là on a inséré une seule entrée :
 *                         
    db       -> Dans la base en cours, la base 'things'
    .peoples -> Dans la collection 'peoples'
    
    avec l'identifiant '1', le nom 'bob' et l'age '45'.
 * 
 * 
 * On ecrit les données a insérer en langage "JSON" :
 *    {
 *      propriété1:valeur,
 *      propriété2:valeur
 *     }
 *  
 * 
 * Si tout s'est bien passé, ça devrait t'afficher : 
 
        WriteResult({ "nInserted" : 1 })
  
 * 
 * 
 * 1.2. L'api:
 *  * que tu viens de créer: "monApi"
 * Crée un dossier "monApi" quelque part, et colle ce fichier dedans.
 * 

 * 
 * (tu peux voir ce que contient le dossier en tapant:  dir 
 *  et tu peux 'remonter' dans les dossier en tapant: ../ )
 * 
 * Quand tu es dans le dossier, tu tape:
 * 
 *      npm init -y
 *  
 * Cette commande va initialiser le projet Node, et créer un fichier
 * "package.json"
 * 
 * Toujours dans la console, tu tape:
 * 
 *      npm install express
 * 
 * ça va installer express pour le projet.
 * 
 * Toujours dans la console, tu tape : 
 * 
 *      npm install mongodb
 * 
 * Pour installer le client mongodb pour le projet
 * 
 * Toujours dans la console, tu tape : 
 * 
 *      npm install body-parser --save
 * 
 * Pour installer le client body-parser pour le projet. C'est un "middleware", un
 * intéermediaire qui va nous aider à manipuler les requêtes HTTP.
 * 
 * Dans le fichier "package.json", tu vérifie qu'il y a bien un truc dans ce genre là :
 * 
 *  "dependencies": {
 *     "body-parser": "^1.19.0",
 *     "express": "^4.17.1",
 *     "mongodb": "^4.1.2"
 *   }
 * 
 * 
 * Ensuite, voila le code 'expliqué'. 
 * Pour le lancer, tu vas dans la console, et tu tape 
 * 
 *      node app.js
 * 
 */

// On définit le port.  C'est grâce à ça que l'api communique avec le reste du monde.
const port = 3000;

// Je récupère un message d'un autre fichier
const message = require('./messages')

// #### 1. Connection à MongoDb et 'population' de la base

// Ca c'est des variables indispensables pour se connecter a Mongo
// * URL de mongodb
const url = 'mongodb://localhost:27017';
// * Le nom de la base
const dbName = 'things';

// On récupère bodyparser
const bodyParser = require('body-parser')


// On va commencer par se connecter a Mongo et manipuler la base pour y ajouter des choses.

// 1.1. On récupère le 'client' MongoDb
const mongoClient = require('mongodb').MongoClient;

// 1.2. On se connecte à Mongo
mongoClient.connect(url, (error, client)=> {
    
    // On gère les potentielles erreurs de connexion
    if(error) {
        console.log("Erreur connection");
        throw error;
    }
    // Sinon on confirme que ça marche
    else{
        console.log("Connecté à MongoDb");
    }
    
    // on récupère la base
    const db = client.db(dbName);   

    // On récupère la collection
    const collection =  db.collection('peoples');

    // 1.3. POUR INSERER DES DONNES

    // 1.3.1. Soit directement depuis le code JavaScript :
    // 1.3.1.1. Creation de l'objet
    const objectTonInsert = {
        identifiant:3,
        nom:"Sam",
        age:37
     }

     // 1.3.1.2. Insertion dans la base
    collection.insertOne(objectTonInsert, (err, res)=>{
        if(err) throw err;
        console.log("1 document inséré")
    })

    // 1.3.2. Soit depuis une autre page (index.html) qui va envoyer au serveur
    // une requete 'POST' avec l'objet à insérer.
    // On utilise les "routes", j'explique plus bas.
    // Depuis le JavaScript, on utilise a ce moment là "app.post(....)""
    app.post('/add_peoples', (req, res)=> {
        console.log("Reçu :\nNom: '" + req.body.nom + " - Age: " + req.body.age +"'\n Par une requete POST\n" );
        // Utilisation de mongodb pour insérer l'objet : 
        // On va utiliser "then + catch" pour gérer les erreurs
        collection.insertOne(req.body)
        .then(result => {
            console.log(result)
            res.redirect('/index');
        })
        .catch(error => console.error(error))
    })

    // 1.4. POUR RECUPERER DES DONNEES

    // 1.4.1. Récupérer toutes les entités
    const peoples = collection.find({});

    console.log("Tous les élements dans la base : ");
    peoples.forEach(element => {
        console.log("Element :" + element.identifiant + ", nom : ", element.nom);
    });
    console.log("########################")

    // 1.4.2. Récupérer selon une requete --> tous les objets dont le nom est 'sam'
    var query = { nom: "Sam"};

    console.log("Tous les élémets dans la base répondant a la requete 'nom = sam'");
    const Sam = collection.find(query).toArray((err, res)=> {
        if(err) throw err;
        console.log(res);
    })  
    
    // 1.4.3. Récupérer et renvoyer vers une route
    app.get('/get_peoples', (req,res)=> {
        const cursor = collection.find().toArray()
        .then(results => {
            console.log(results)
        })
        .catch(error => console.error(error))
        console.log(cursor);
    });
});



// #### 2. Creation de l'instance d'une application express
 
// 2.1. On récupère le framework express
const express = require('express');

// 2.2. On instancie express --> On crée un "objet" express
const app = express();
// On configure l'api pour qu'elle utilise body-parser
// "urlencoded" dit a body-parser d'extraire les données depuis le formulaire de la page web
// et de les ajouter à la propriété "body" de l'objet 'requete', qui represente ta requette HTTP
app.use(bodyParser.urlencoded({extended: true}))

// 2.4. ROUTAGE :
//
// app.get() te permet de 'router', c'est à dire de définir comment 
// ton application va répondre quand on ira sur l'adresse '3000/'
//
// Entre les parenthèses, le premier truc, c'est la 'route', le chemin.
// le '/' c'est pour dire qu'on est à la racine de l'adresse. 
// Si tu veux d'autres adresse, tu rajoute des mots là. (:
// Exemple : Si tu voulais que ton appli reagisse à l'adresse '3000/kiwi/',
// tu mettrait 'app.get('/kiwi/', ...)
//
// Le second truc entre les parenthèses, c'est le 'handler', la méthode executée 
// quand la 'route' est trouvée et que tout est ok.
// 
// La, le '(request, response) =>  ...' c'est une 'lambda'. C'est une manière raccourcie
// d'écrire une 'méthode', mais je vais pas rentrer dans les détails.
// Ca évite d'avoir à écrire : 
//
//      app.get('/', function (request, response) {
//          res.send('Hello World!');
//      });
//
// 'request' c'est un objet qui contient des infos sur la REQUETE http qui a déclenché la méthode
// 'response' c'est l'objet qui va contenir la réonse
// Ici on dit à l'objet 'response' de renvoyer 'hello world'.
//
// Route racine
app.get('/', (request, response) => response.send('Hello world'));

// Route vers "kiwi"
app.get('/kiwi', (request, response) => response.send('Un peu decevant cette page.'));

// Route vers une page ecrites en HTML :
app.get('/index', (req, res) => {
    // __dirname : c'est le dossier de l'application
    res.sendFile(__dirname+ '/index.html')
})

// Mais on peut lui passer d'autres trucs, comme des objets.
// Pour ça, il faut 'serialiser' --> transformer en objet que le web peut transporter.
// C'est pour ça qu'on utilise le format 'JSON'. Ca tombe bien, c'est le format de MongoDB

// Tu peux stocker ton objet dans une variable, et l'envoyer par exemple 
const peopleToSend =  [
    {
        identifiant:1,
        nom:"Bob",
        age:45
     },
    {
        identifiant:2,
        nom:"Noah",
        age:27
     }
];

// Routage vers 'peoples' avec un objet transmis
// Pour envoyer des objets il te suffit ensuite de les passer dans ta réponse :
app.get('/peoples', (request, response) => response.json(peopleToSend));

// Demarrage de l'application web
app.listen(port, () => console.log(messageToIscia));