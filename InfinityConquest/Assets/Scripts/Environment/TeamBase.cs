using UnityEngine;
using System.Collections;

public class TeamBase : MonoBehaviour 
{
	public bool isEnnemyBase = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Flag") 
		{
			if (other.gameObject.GetComponent<DrapeauBehavior> ().isEnemyFlag != isEnnemyBase) {
				other.gameObject.GetComponent<DrapeauBehavior> ().Goal ();
			}
		}
	}
		
}
