using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	//public GameObject Vaisseau;
	public int ScoreAllie;
	public int ScoreEnnemi;
	public int SCOREMAXIMUM;
	public int NumberOfLevel = 1 ;

	// +++++Pour la minimap+++++++++++++
	public GameObject panelEnnemyFlag;
	public GameObject panelAllierFlag;
	public GameObject baseAllier; 
	public GameObject baseEnnemy;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (NumberOfLevel == 1) {
			ModifyTheSmallMap ();
		} 
	

	}
		
	/// <summary>
	/// Increases the ennemies score.
	/// </summary>
	public void IncreaseEnnemiesScore()
	{
		ScoreEnnemi++;
		CheckMaximumScore ();
	}

	/// <summary>
	/// Increases the allies score.
	/// </summary>
	public void IncreaseAlliesScore()
	{
		ScoreAllie++;
		CheckMaximumScore ();
	}

	private void CheckMaximumScore()
	{
		if (ScoreAllie >= SCOREMAXIMUM )
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Intermediaire");
		}
		if (ScoreEnnemi >= SCOREMAXIMUM )
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Loose");
		}
	
	}

	private void ModifyTheSmallMap(){


		// POUR LA POSITION DU DRAPEAU ALLIER 

		// Ressources de calcul
		float positionBaseAllierX = GameObject.Find("PanelBaseAllier").GetComponent<RectTransform>().anchoredPosition.x;
		float positionBaseAllierY = GameObject.Find("PanelBaseAllier").GetComponent<RectTransform>().anchoredPosition.y ;
		float positionReelBaseAllierX =baseAllier.GetComponent<Transform>().position.x +1;
		float positionReelBaseAllierY = baseAllier.GetComponent<Transform>().position.z;
		float positionReelDrapeauAllierX = GameObject.Find("Drapeau_Gentil").GetComponent<Transform>().position.x +1;
		float positionReelDrapeauAllierY = GameObject.Find("Drapeau_Gentil").GetComponent<Transform>().position.z;

		// produit en croix : X  = PannelBaseAllier x PositionReelDrapeauAllier / PositionReelBaseAllier
		float PanelAllierFlagX = 0.05f *  positionReelDrapeauAllierX  ;
		float PanelAllierFlagY = positionBaseAllierY *  positionReelDrapeauAllierY / positionReelBaseAllierY ;

		panelAllierFlag.GetComponent<RectTransform>().anchoredPosition = new Vector2(PanelAllierFlagX, PanelAllierFlagY);


		// POUR LA POSITION DU DRAPEAU ENNEMY 


		// Ressources de calcul
		float positionBaseEnnemyX = GameObject.Find("PanelBaseEnnemy").GetComponent<RectTransform>().anchoredPosition.x;
		float positionBaseEnnemyY = GameObject.Find("PanelBaseEnnemy").GetComponent<RectTransform>().anchoredPosition.y ;
		float positionReelBaseEnnemyX =baseEnnemy.GetComponent<Transform>().position.x +1;
		float positionReelBaseEnnemyY = baseEnnemy.GetComponent<Transform>().position.z;
		float positionReelDrapeauEnnemyX = GameObject.Find("Drapeau_Ennemi").GetComponent<Transform>().position.x +1;
		float positionReelDrapeauEnnemyY = GameObject.Find("Drapeau_Ennemi").GetComponent<Transform>().position.z;

		// produit en croix : X  = PannelBaseAllier x PositionReelDrapeauAllier / PositionReelBaseAllier
		float PanelEnnemyFlagX = 0.05f *  positionReelDrapeauEnnemyX ;
		float PanelEnnemyFlagY = positionBaseEnnemyY *  positionReelDrapeauEnnemyY / positionReelBaseEnnemyY ;

		panelEnnemyFlag.GetComponent<RectTransform>().anchoredPosition = new Vector2(PanelEnnemyFlagX, PanelEnnemyFlagY);

	}


}
