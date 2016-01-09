using UnityEngine;
using System.Collections;

public class CatcherBehavior : Ennemy 
{
	void Start () {
		initalisation ();
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
			ChasePlayer ();
		}

		if (Input.GetKeyDown ("p")) 
		{
			if (hasFlag)
			{
				playerFlag.Detach ();
			}
		}
	}

	private void MoveToPlayerFlag()
	{
		Vector3 flagDirection = getTargetDirection (playerFlag.transform.position);
		flagDirection.Normalize ();
		rb.velocity = flagDirection * speed;

		transform.rotation = GetRotationToTarget (playerFlag.transform.position);
	}

	private void MoveToBase()
	{
		Vector3 baseDirection = getTargetDirection (ennemyBase.transform.position);
		baseDirection.Normalize ();
		rb.velocity = baseDirection * speed;

		transform.rotation = GetRotationToTarget (ennemyBase.transform.position);
	}

	private void ChasePlayer()
	{
		Vector3 playerDirection = getTargetDirection (player.transform.position);
		playerDirection.Normalize ();
		rb.velocity = playerDirection * speed;

		transform.rotation = GetRotationToTarget (player.transform.position);
	}
}