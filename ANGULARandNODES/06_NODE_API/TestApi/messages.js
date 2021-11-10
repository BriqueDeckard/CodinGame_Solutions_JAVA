//---- Fichier exporté [messages.js] ----

// Imports :
const api_config = require('./api_config');

// Ca c'est un message que je vais afficher dans la console plus tard :
const messageToIscia = `Ton application "ecoute" sur le port ${api_config.port},\n
Tu peux aller sur http://localhost:3000/, il devrait t'afficher 'hello world'.\n
Si tu vas sur http://localhost:3000/kiwi/ il devrait t'afficher autre chose. \n
Si tu vas sur http://localhost:3000/peoples/ tu devrais voir deux "objets" \n
Si tu vas sur http://localhost:3000/index/ tu devrais voir un formulaire. \n
Si tu clique sur "soumettre" dans ce formulaire, tu devrais voir s'afficher "hello people" dans ta console.`

module.exports = messageToIscia;