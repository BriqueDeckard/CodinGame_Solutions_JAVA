# CODES HTTP:

<details><summary>1XX: (Infos)</summary>
	<ul>
		<li>Infos ! </li>
	</ul>
</details>
<details><summary>2XX: (Succès)</summary>	
	<ul>
		<li>200 - Succès de la requête</li>
		<li>201 - Ressource créée</li>
		<li>204 - Pas de contenu</li>
	</ul>
</details>
<details><summary>3XX: (Redirection)</summary>
	<ul>
		<li>300 - Plusieurs choix de ressources</li>
		<li>301 - Redirection permanente </li>
		<li>302 - Redirection temporaire </li>
	</ul>
</details>
<details><summary>4XX: (Erreur client HTTP -> BACK)</summary>
	<ul>
		<li>400 - Bad request</li>
		<li>401 - Utilisateur non authentifié</li>
		<li>403 - Accès refusé</li>
		<li>404 - Page non trouvée</li>
		<li>405 - Methode non authorisée</li>
	</ul>
</details>
<details><summary>5XX: (Erreur interne serveur)</summary>
	<ul>
		<li>501 - Non implémenté</li>
		<li>502 - Bad gateway</li>
		<li>503 - Service indisponible</li>
		<li>504 - Timeout</li>
	</ul>
</details>

# APPELS HTTP: 
<details><summary>Angular: </summary>
	```
	HttpClient: + verbe.
	```
	Les méthodes retournent un observable auquel il faut s'abonner pour déclencher le traitement.
</details>
<details><summary>Vue.js: </summary>
	app.get('route', (req, res) => { 
			// Traitement avec res
		});
</details>
<details><summary>React.js: </summary>
	Axios.get('URL').then((res) => {
		    // Traitement avec res
		});
</details>

