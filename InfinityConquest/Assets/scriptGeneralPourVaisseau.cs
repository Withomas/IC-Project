using UnityEngine;
using System.Collections;

public class scriptGeneralPourVaisseau : MonoBehaviour {
	
	private int nombrePointDeVie = 100;
	private float _speed = 700.0f;
	public int indiceDeLEquipe ; // indice : -1 si vaisseau enemie et indice :1 si vaisseau allier
	private string etat= "RechercheDrapeau";

	/*
	 * Voici la liste des états possibles pour les vaisseaux 
	 * RechercheDrapeau
	 * Poursuivre
	 * Fuir
	 * RamenerLeDrapeauALaBase
	*/
	private int nombreDeFramePasse = 0;


	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {


		// Le fonction suivante ajoute un point de vie au vaisseau toutes les 200 frames
		rajouteUnPointDeVieSelonNombreFramesPassees();
		// Selon la situation change d'état 
		changeEtatDuVaisseauSelonSituation();
		// Selon l'état du vaisseau effectue une action
		effectueUneActionSelonLEtat();



	}


	// Rajoute des points de vie toutes les 200 frames 
	private void rajouteUnPointDeVieSelonNombreFramesPassees()
	{
		// Le paragraphe suivant ajoute un point de vie au vaisseau toutes les 200 frames 
		nombreDeFramePasse = nombreDeFramePasse + 1;
		if (nombreDeFramePasse < 200) {
			nombreDeFramePasse = 0; 
			if (nombrePointDeVie < 100) {
				nombrePointDeVie = nombrePointDeVie + 1; 
			}
		}
	}



	// Selon l'état du vaisseau effectue une action
	private void effectueUneActionSelonLEtat()
	{
		// Selon l'état du vaisseau effectue une action
		if (etat == "RechercheDrapeau") {
			if (indiceDeLEquipe == 1) {
				// le vaisseau recherche la collision avec le drapeau ennemie
				// TO DO
			} else {
				// le vaisseau recherche la collision avec le drapeau allier
				// TO DO
			}
		}
		if (etat == "Poursuivre")
		{
			if (indiceDeLEquipe == 1) {
				// Recherche de l'ennemie le plus proche et poursuivre
				// TO DO 
			} else {
				// Recherche de l'allié le plus proche et poursuivre
				// TO DO			
			}
		}
		if (etat == "Fuir") {
			if (indiceDeLEquipe == 1) {
				// récupération des coordonnées de l'ennemi le plus proche
				// fuite à l'opposé de là où est l'ennemie le plus proche
				// TO DO
			} else {
				// récupération des coordonnées de l'allié le plus proche
				// fuite à l'opposé de là où est l'allié le plus proche
				// TO DO			
			}
		}
		if (etat == "RamenerLeDrapeauALaBase") {
			if (indiceDeLEquipe == 1) {				
				// Le vaisseau fonce vers la base allier 
				// TO DO
			} else {				
				// le vaisseau fonce vers la base ennemie
				// TO DO			
			}
		}
	}


	//Selon le jeu, change l'état du vaisseau
	private void changeEtatDuVaisseauSelonSituation()
	{			
		float seuilDistanceAdverseDangereux = 200f; 
		if (indiceDeLEquipe == 1) {
			// Si le vaisseau a un enfant drapeau 
			// Alors l'etat = "RamenerLeDrapeauALaBase" 
			/*if (calculDistanceEnnemiLePlusProche () < seuilDistanceAdverseDangereux) {
				if (nombrePointDeVie < 20) {
					etat = "Fuir";
				}
				else {
					etat = "Poursuivre";
				}
			}
			*/
		}
	}

	// Retourne la distance avec l'ennemi le plus proche 
	private float calculDistanceEnnemiLePlusProche(){
		float distanceARetourner = 1000000000f; 

		// TO DO
		// Pour chaque vaisseau ennemi
		// Si la distance entre le vaisseau de l'objet et le vaisseau ennemi de la boucle est plus petite que distanceARetourner
		// Alors distanceARetourner = distanceVaisseauEnnemi

		return distanceARetourner;
	}

}
