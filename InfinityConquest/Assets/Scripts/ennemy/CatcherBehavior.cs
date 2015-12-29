using UnityEngine;
using System.Collections;

public class CatcherBehavior : Ennemy 
{
	void Start () {
		initalisation ();
	}

	// Update is called once per frame
	void Update () {
		moveToFlag ();
	}

	void moveToFlag()
	{
		Vector3 flagDirection = getFlagDirection ();
		flagDirection.Normalize ();
		rb.velocity = flagDirection * speed;


		// TO DO : faire en sorte qu'il ne tourne pas sur lui même comme un taré !!!! ON DIRAIS UN CHATTTTTT !!!!
		// faire en sorte de maximiser sa vitesse de rotation
		transform.rotation = Quaternion.FromToRotation(transform.forward, flagDirection);
	}

	private Vector3 getFlagDirection()
	{
		return playerFlag.transform.position - transform.position;
	}
}
