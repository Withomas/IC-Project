﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vie : MonoBehaviour {

	private Text ScorePartie;
	private GameController Controller;
	// Use this for initialization
	void Start () {
		ScorePartie = GetComponent<Text> ();
		GameObject GameController = GameObject.Find ("GameControllerObject");

		if (GameController != null) {
			this.Controller = GameController.GetComponent<GameController>();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
