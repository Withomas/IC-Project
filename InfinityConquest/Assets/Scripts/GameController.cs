using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	//public GameObject Vaisseau;
	public int ScoreAllie;
	public int ScoreEnnemi;
	public int SCOREMAXIMUM;


	//Pour la minimap
	public GameObject panelEnnemyFlag;
	public GameObject panelAllierFlag;
	public GameObject drapeauAllier; 
	public GameObject drapeauEnnemy;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
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
		else if (ScoreEnnemi >= SCOREMAXIMUM)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Loose");
		}
	}

	private void ModifyTheSmallMap(){
		// TO DO
		//panelEnnemyFlag.GetComponent<RectTransform>
	}

}
