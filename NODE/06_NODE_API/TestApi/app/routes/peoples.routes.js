module.exports = (app)=> {
    const peoples = require('../controllers/peoples.controller.js');

    // Creer une personne
    app.post('/peoples', peoples.create);

    // Obtenir toutes les personnes
    app.get('/peoples', peoples.findAll);

    // Obtenir une personne seule grace a l'identifiant
    app.get('/peoples/:peopleId', peoples.findOne);

    // Mettre à jour une personne avec son identifiant
    app.put('/peoples/:peopleId', peoples.update);

    // Supprimer une personne avec son identifiant
    app.delete('/peoples/:peopleId', peoples.delete);
}