from nltk.corpus import stopwords
from nltk import word_tokenize
from nltk.tokenize import sent_tokenize
from nltk.stem.snowball import FrenchStemmer
import re
import nltk

data = u"""Wikipédia est un projet wiki d’encyclopédie collective en ligne, universelle, multilingue et fonctionnant sur le principe du wiki. Aimez-vous l'encyclopédie wikipedia ?"""

# Importer les "stop words" les mots qui n'apportent pas de valeur à l'analyse
# globale du texte
french_stopwords = set(stopwords.words('french'))

# creer une lambda qui va permettre de filtrer un texte à partir de la liste
# des stop words français
filtre_stopfr = lambda text: [token for token in text if token.lower() not in french_stopwords]

print(filtre_stopfr(word_tokenize(data, language="french")))

# comparaison avec un filtre "regex"
print("comparaison avec un filtre \"regex\" : ")

sp_pattern = re.compile( """[\.\!\"\s\?\-\,\']+""", re.M).split

print(sp_pattern(data))

#  Decoupage par phrase avec tokenize
print("Decoupage par phrase avec tokenize : ")

tokenized_sentences = sent_tokenize(data, language="french")

print(tokenized_sentences)

#  Decoupage par mot avec word_tokenize
print("Decoupage par mot avec word_tokenize : ")

tokenized_words = word_tokenize(data, language="french")

print(tokenized_words)

#  Combinaison avec la fonction lambda de filtre
print("Combinaison avec la fonction lambda de filtre")

filtered_tokenized_words =  filtre_stopfr(word_tokenize(data, language="french"))

print(filtered_tokenized_words)

# Ajout de la frequence de sitribution des valeurs avec FreqDist
frequence_distro = nltk.FreqDist(filtered_tokenized_words)
print("Most common words")
print(frequence_distro.most_common)

# Regrouper les mots ayant la même racine syntaxique (stemmatisation) avec la
# fonction stem()
example_words = ["donner", "don", "donne", "donnera", "dons", "test"]
stemmer = FrenchStemmer()

for w in example_words:
    print(stemmer.stem(w))
    
