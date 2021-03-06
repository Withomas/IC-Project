﻿using UnityEngine;
using System.Collections;

public class CatcherBehavior : Ennemy 
{
	public float PlayerDistance;

	void Start () {
		initalisation ();
	}

	void OnEnable()
	{
		reset ();
	}

	// Update is called once per frame
	void Update () {

		//On annule les rotations
		rb.angularVelocity = Vector3.zero;

		if (hasFlag) 
		{
			MoveToBase ();
		}
		else if (playerFlag.isCatchable) 
		{
			MoveToPlayerFlag ();
		}
		else
		{
			DefenceBehavior ();
		}

		PlayerDistance = getPlayerDistance ();
	}

	private void DefenceBehavior()
	{


		if (getPlayerDistance () < shootDistance)
		{
			Shoot ();
		}

		if (getPlayerDistance () < chaseDistance) {
			ChasePlayer ();
		} 
		else 
		{
			ChasePlayer ();
		}
	}

	private void TurnAroundBase()
	{
		//do stuff !!!
	}
}