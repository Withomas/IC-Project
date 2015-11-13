using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	#region propriétés publiques
	public GameObject Spaceship;
	#endregion

	#region propriétés privées
	Vector3 offset;
	Vector3 Rotation;
	#endregion

	void Start()
	{
		offset = transform.position - Spaceship.transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		transform.position = Spaceship.transform.position + offset;
		Rotation = Spaceship.transform.eulerAngles;
		transform.eulerAngles = Rotation;
	}
}
