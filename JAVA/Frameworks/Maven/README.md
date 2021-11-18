# MAVEN

## ABOUT

Maven est un outil de construction de projets (build) open source développé par la fondation Apache, initialement pour les besoins du projet Jakarta Turbine. Il permet de faciliter et d'automatiser certaines tâches de la gestion d'un projet Java.

Le site web officiel est http://maven.apache.org

Il permet notamment :

d'automatiser certaines tâches : compilation, tests unitaires et déploiement des applications qui composent le projet
de gérer des dépendances vis-à-vis des bibliothèques nécessaires au projet
de générer des documentations concernant le projet

*GENERER UN PROJET ARCHETYPE:*
--> mvn archetype:generate -DarchetypeArtifactId=maven-archetype-quickstart -DarchetypeVersion=1.1

*COMPILER:*
--> mvn package
    - copié les ressources de l'application
    - Compilé les sources de l'application
    - compilé les sources des tests
    - exécuté les tests sur l'application 
    - généré un JAR de l'application

*LANCER LE JAR:*
--> java -cp target/mon-appli.jar le.nom.du.package.Classe