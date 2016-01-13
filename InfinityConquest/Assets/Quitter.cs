using UnityEngine;
using System.Collections;

public class Quitter : MonoBehaviour {

	public void quitter()
	{
		//UnityEngine.SceneManagement.SceneManager.LoadScene (scene);
		Application.Quit();
	}
}
