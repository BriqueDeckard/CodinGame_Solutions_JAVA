const mongoose = require('mongoose');

const PeopleSchema = mongoose.Schema({
    nom: String,
    age: String
},{
    timestamps: true
});

module.exports = mongoose.model('People', PeopleSchema);