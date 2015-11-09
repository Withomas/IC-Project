using UnityEngine;
using System.Collections;

public class SpaceController : MonoBehaviour {
	private Rigidbody SpaceRigidBody;
	// Use this for initialization
	void Start () {
		SpaceRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float AxeHorizontal = Input.GetAxis ("Horizontal");
		float AxeVertical = Input.GetAxis ("Vertical");
	
		Debug.Log (AxeHorizontal);


	}
}
