using UnityEngine;
using System.Collections;

public class AccrocheVaisseau : MonoBehaviour {
	
	public GameObject PointAccroche;
	public bool hasFlag;

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

			if ((other.gameObject.GetComponent<DrapeauBehavior>().isEnemyFlag == isPlayer) &&
				(other.gameObject.GetComponent<DrapeauBehavior> ().isCatchable)) 
			{
				other.gameObject.GetComponent<DrapeauBehavior> ().isCatchable = false;
				other.gameObject.transform.parent = PointAccroche.gameObject.transform;
				other.gameObject.transform.localPosition = Vector3.zero;
				hasFlag = true;
			}
		}
	}
}
