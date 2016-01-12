using UnityEngine;
using System.Collections;

public class DrapeauBehavior : MonoBehaviour 
{
	public bool isEnemyFlag = true;
	public float respawnDelay = 1.0f;

	public bool isCatchable = true; // means that no one owns it

	private Vector3 spawnPosition;

	public GameController controller;

	void Start()
	{
		spawnPosition = transform.position;
	}

	public void Detach()
	{
		gameObject.GetComponentInParent<AccrocheVaisseau> ().hasFlag = false;
		isCatchable = true;
		gameObject.transform.parent = null;
	}

	public void Goal()
	{
		Detach ();
		gameObject.GetComponent<Collider> ().enabled = false;
		isCatchable = false;
		gameObject.transform.GetChild (0).gameObject.SetActive (false);

		StartCoroutine (Respawn());
	}

	private IEnumerator Respawn()
	{
		//Augmentation des scores
		if (isEnemyFlag) {
			controller.IncreaseAlliesScore ();
		} else {
			controller.IncreaseEnnemiesScore ();
		}

		yield return new WaitForSeconds(Mathf.Max (respawnDelay, 0));

		transform.position = spawnPosition;
		isCatchable = true;
		gameObject.GetComponent<Collider> ().enabled = true;
		gameObject.transform.GetChild (0).gameObject.SetActive (true);


	}
}
