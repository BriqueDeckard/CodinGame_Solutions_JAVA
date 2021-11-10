const express = require('express');
const bodyParser = require('body-parser');
const { request, response } = require('express');

// Creation d'une app Express
const app = express();

// Récupération des routes
require('./app/routes/peoples.routes.js')(app);

// Definition du port
const port = 3000;

// Parsing des requêtes
app.use(bodyParser.urlencoded({ extended: true }))
app.use(bodyParser.json())

// Une route simple
app.get('/', (request, response) => {
    response.json({"Message":"Bienvenu dans cette aplication Create/Read/Update/Delete"})
});

// Ecoute pour les requêtes
app.listen(port, () => {
    console.log(`Le serveur ecoute maintenant le port ${port}`)
});

// Configuration de la base de données
const dbConfig = require('./config/database.config.js');
const mongoose = require('mongoose');

mongoose.Promise = global.Promise;

// Connection à la base de données
mongoose.connect(dbConfig.fullUrl, {
    useNewUrlParser: true
}).then(() =>{
    console.log("Succes de la connection à la base de données.");
}).catch(err => {
    console.log("Erreur de connection à la base de données. --> ", err);
    process.exit();
})

