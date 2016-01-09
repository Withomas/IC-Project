using UnityEngine;
using System.Collections;

[System.Serializable]
public struct SpawnPool
{
	public ObjectPool pool;
	public int numberToSpawn;
}

public class EnnemyManager : MonoBehaviour 
{
	public Vector3 spwanRotation;

	public SpawnPool[] ennemyPools;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < ennemyPools.Length; i++) 
		{
			Vector3 spawnPosition = transform.position;
			for (int j = 0; j < ennemyPools[i].numberToSpawn; j++) 
			{
				ennemyPools[i].pool.Spawn(spawnPosition, Quaternion.Euler (spwanRotation));
				spawnPosition += Vector3.left * 200;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
