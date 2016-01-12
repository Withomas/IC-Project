using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	//public GameObject Vaisseau;
	public int ScoreAllie;
	public int ScoreEnnemi;
	private const int SCOREMAXIMUM = 1;

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
	}

	/// <summary>
	/// Increases the allies score.
	/// </summary>
	public void IncreaseAlliesScore()
	{
		ScoreAllie++;
	}

	private void CheckMaximumScore()
	{
		if (ScoreAllie >= SCOREMAXIMUM )
		{
			//Passer au niveau suivant.
		}
		else if (ScoreEnnemi >= SCOREMAXIMUM)
		{
			//Le joueur a perdu
		}
	}

}
