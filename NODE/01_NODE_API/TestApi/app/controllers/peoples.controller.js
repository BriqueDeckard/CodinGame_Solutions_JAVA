const People = require('../models/peoples.model.js');

// Creer et sauver une personne dans la base
exports.create = (req, res)=> {
    // Valider la requête
    if(!req.body.content){
        return res.status(400).send({
            message: "Le contenu d'une personne ne peut etre vide."
        });
    }

    // Creer une personne
    const people = new People({
        nom: req.body.nom || "Anonyme",
        age: req.body.age
    });

    // Sauver la personne dans la base
    people.save()
    .then(data => {
        res.send(data);
    }).catch(err => {
        res.status(500).send({
            message: err.message ||"Une erreur est subvenue pendant la creation de la personne"
        });
    }); 
};

// Retrouver et retourner toutes les personnes dans la base
exports.findAll = (req, res) => {
    People.find()
    .then(peoples => {
        res.send(peoples);
    }).catch(err => {
        res.status(500).send({
            message: err.message ||"Une erreur est subvenue pendant l'obtention des personnes"
        });
    });
};

// Retrouver une personne seule grâce à son ID
exports.findOne = (req, res) => {
    People.findById(req.params.peopleId)
    .then(people => {
        if(!people){
            return res.status(404).send({
                message: 'Personne non trouvée pour l\'ID ' + req.params.peopleId
            });
        }
    }).catch(err => {
        if(err.kind === 'ObjectId'){
            return res.status(404).send({
                message: 'Personne non trouvée pour l\'ID ' + req.params.peopleId
            });
        }
        return res.status(500).send({
            message: 'Erreur dans une recherche pour l\'identifiant' + req.params.peopleId
        });
    });
};

// Mettre à jour une note identifiée par son id dans la requête
exports.update = (req, res) => {

};

// Supprimer une personne avec l'identifiant donné dans la requête
exports.delete = (req, res) => {

};