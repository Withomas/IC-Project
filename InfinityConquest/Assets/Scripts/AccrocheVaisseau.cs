using UnityEngine;
using System.Collections;

public class AccrocheVaisseau : MonoBehaviour {
	
	public GameObject PointAccroche;

	private bool isPlayer;

	void Start () {
		if (this.gameObject.tag == "Player") {
			isPlayer = true;
		} else {
			isPlayer = false;
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Flag") 
		{
			if (other.gameObject.GetComponent<DrapeauBehavior>().enemyFlag == isPlayer) {
				Debug.Log ("prout");
				other.gameObject.transform.parent = PointAccroche.gameObject.transform;
			}
		}
	}
}
