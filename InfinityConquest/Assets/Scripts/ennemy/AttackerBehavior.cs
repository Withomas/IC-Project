using UnityEngine;
using System.Collections;

public class AttackerBehavior : Ennemy
{
	public float PlayerDistance;
	// Use this for initialization
	void Start () {
		initalisation ();
	}

	void OnEnable()
	{
		reset ();
	}
	
	// Update is called once per frame
	void Update () {
		
		PlayerDistance = getPlayerDistance ();

		if (hasFlag)
		{
			MoveToBase ();
		} 
		else
		{
			AttackBehavior ();
		}
	}

	private void AttackBehavior()
	{
		//On annule les rotations
		rb.angularVelocity = Vector3.zero;

		if (getPlayerDistance () < shootDistance) {
			Shoot ();
		} else if (getPlayerDistance () < chaseDistance) 
		{
			ChasePlayer ();
		}

		//ChasePlayer ();
	}
}
