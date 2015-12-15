using UnityEngine;
using System.Collections;

public class AccrocheVaisseau : MonoBehaviour {
	
	public GameObject PointAccroche;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Drapeau_Ennemi") 
		{
			col.transform.parent = PointAccroche.transform;
			col.transform.position = PointAccroche.transform.position;
			col.transform.rotation = PointAccroche.transform.rotation;
		}
	}
}
