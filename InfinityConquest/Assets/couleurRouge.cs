using UnityEngine;
using System.Collections;

public class couleurRouge : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.color =  new Color(0.2F, 0.3F, 1F, 1F);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
