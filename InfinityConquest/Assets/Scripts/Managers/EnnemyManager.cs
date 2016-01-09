using UnityEngine;
using System.Collections;

public class EnnemyManager : MonoBehaviour 
{
	public Vector3 spwanRotation;

	public ObjectPool ennemyPool;

	// Use this for initialization
	void Start () {
		ennemyPool.Spawn (Vector3.zero, Quaternion.Euler(spwanRotation));
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("space")) {
			ennemyPool.Spawn (Vector3.zero, Quaternion.Euler(spwanRotation));
		}
	}
}
