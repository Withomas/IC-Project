using UnityEngine;
using System.Collections;

public class dontDestroyMusic : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
	}
	
}
