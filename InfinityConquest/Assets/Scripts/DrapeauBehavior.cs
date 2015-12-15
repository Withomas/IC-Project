using UnityEngine;
using System.Collections;

public class DrapeauBehavior : MonoBehaviour {

	void OnTriggerEnter(Collider vaisseau)
	{

		foreach (var transform in tag) {
			
		}

		Debug.Log(vaisseau.transform.ToString());

	}
}
