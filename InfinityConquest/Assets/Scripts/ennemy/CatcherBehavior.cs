using UnityEngine;
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
			TurnAroundBase ();
		}
	}

	private void TurnAroundBase()
	{
		//do stuff !!!
	}
}