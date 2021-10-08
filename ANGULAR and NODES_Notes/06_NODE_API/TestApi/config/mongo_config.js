//---- VARIABLES POUR MONGODB ----

// Ca c'est des variables indispensables pour se connecter a Mongo

// * URL de mongodb
const url = 'mongodb://localhost:27017';
// * Le nom de la base
const dbName = 'things';

// On exporte les variables.
module.exports = url, dbName;