#SPRINGBOOT

pom.xml hérite du parent spring-boot-starter-parent qui nous permet de ne plus nous soucier des versions des dépendances et de leur compatibilité.

Avec spring initializer : 
- Jackson : permet de parser JSON et faire le lien entre les classes Java et le contenu JSON.
- Tomcat : intégré, va nous permettre de lancer notre application en exécutant tout simplement le jar sans avoir à le déployer dans un serveur d'application.
- Hibernate : facilite la gestion des données.
- Logging grâce à logback et autres.