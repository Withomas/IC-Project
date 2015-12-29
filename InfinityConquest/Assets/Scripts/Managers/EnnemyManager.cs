using UnityEngine;
using System.Collections;

public class EnnemyManager : MonoBehaviour 
{
	public ObjectPool ennemyPool;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("s")) {
			ennemyPool.Spawn (Vector3.zero);
		}
	}
}
