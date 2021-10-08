import spacy
from spacy import displacy

#  Import de la librairie
nlp = spacy.load('fr')

# tokenisation mots par mots
print("TOKENISATION de la phrase")
doc = nlp('Demain je travaille à la maison')
for token in doc:
    print(token.text)
    
# Regardons de plus près
print("TOKENISATION plus détaillée")
for token in doc:
    print("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}".format(
        # le mot originel
        token.text,
        token.idx,
        # la forme de base du mot
        token.lemma_,
        token.is_punct,
        token.is_space,
        token.shape_,
        # Le tag POS
        token.pos_,
        # les infos detaillées POS
        token.tag_,
        token.ent_type_,
        token.is_alpha
    ))
    
# Tokenisation de phrase
doc = nlp("Demain je travaille à la maison. Je vais pouvoir faire du NLP.")
for sent in doc.sents:
    print(sent)

# Tokenisation des phrases nominales
doc = nlp("Terrible desillusion pour la championne du monde.")
for chunk in doc.noun_chunks:
    print(chunk.text, " --> ", chunk.label_)
    
# Reconnaissance d'entité statistiques (NER) qui va assigner des 
# etiquettes à des plages contigues de tokens
doc = nlp("Demain je travaille en France chez Tableau")
for ent in doc.ents:
    print(ent.text, ent.label_)
    
# Analyse de dépendances qui va pouvoir recomposer une phrase en reliant les 
# mots dans leur contexte.
for token in doc:
    print("{0}/{1} <--{2}--{3}/{4}".format(
                                        token.text,
                                        token.tag_,
                                        token.dep_,
                                        token.head.text,
                                        token.head.tag_))
    
displacy.render(doc, style='dep', jupyter=False, options={'distance':130})