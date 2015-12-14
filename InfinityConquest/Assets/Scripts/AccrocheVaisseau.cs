using UnityEngine;
using System.Collections;

public class AccrocheVaisseau : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Drapeau_Ennemi") {
			col.transform.parent =this.transform;
		}
	}
}
