using UnityEngine;
using System.Collections;

public class loadOnClick : MonoBehaviour
{

	public void loadScene(string scene)
    {
		Application.LoadLevel(scene);
    }
}
