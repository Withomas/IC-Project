using UnityEngine;
using System.Collections;

public class ManuPause : MonoBehaviour {

	private bool isPaused = false; 
	public Canvas pauseCanvas ;
	void Start () {
		Cursor.visible = false; 
			}

	// Update is called once per frame
	void Update () {




		if (Input.GetKeyDown (KeyCode.Escape))
			isPaused = !isPaused;


		if (isPaused) 
		{
			
			//(GameObject.Find ("Joueur").GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
			//(GameObject.Find ("Camera").GetComponent ("MouseLook") as MonoBehaviour).enabled = false;
			pauseCanvas.enabled = true;
			Cursor.visible = false; 			//pausepanel.SetActive (true);
			Time.timeScale = 0f;
		}
		else
		{
			//(GameObject.Find ("Joueur").GetComponent ("MouseLook") as MonoBehaviour).enabled = true;
			//(GameObject.Find ("Camera").GetComponent ("MouseLook") as MonoBehaviour).enabled = true;
			pauseCanvas.enabled = false;
			Cursor.visible = true; 			//pausepanel.SetActive (false);
			Time.timeScale = 1f;
		}





	}


	/*void OnGUI()
	{
		
		if (isPaused) {
			
			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continuer")) {
				isPaused = false;

			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 40, 80, 40), "Quitter")) {
				UnityEngine.SceneManagement.SceneManager.LoadScene ("main");
			}
		
		
		
		} 
	} */

}
