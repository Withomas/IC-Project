using UnityEngine;
using System.Collections;

public class EnnemyManager : MonoBehaviour 
{
	public ObjectPool ennemyPool;

	// Use this for initialization
	void Start () {
		ennemyPool.Spawn (Vector3.zero);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("space")) {
			ennemyPool.Spawn (Vector3.zero);
		}
	}
}
