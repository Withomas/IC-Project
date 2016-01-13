using UnityEngine;
using System.Collections;

public class loadOnClick : MonoBehaviour
{

	public void loadScene(string scene)
    {
		UnityEngine.SceneManagement.SceneManager.LoadScene (scene);
		//Application.LoadLevel(scene);
    }
}
