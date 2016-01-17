using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScriptLvl2 : MonoBehaviour {
	private float startTimer;
	private float  minutes ;
	private float seconds;

	// Use this for initialization
	void Start () {
		startTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		gestionDuTimerAffichage ();
	
	}

	private void gestionDuTimerAffichage(){

		// timer 
		float time = Time.time - startTimer;

		float tempsRestant = 60 * 2; // une minute x 3
		time = tempsRestant - time;
		minutes = time / 60;
		seconds = time % 60;
		this.GetComponent<Text>().text = (int) minutes + " : " + (int) seconds;

		// lancement du game over si le temps est écoulé 
		if (time <= 0f) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Loose");
		}
	}


}
