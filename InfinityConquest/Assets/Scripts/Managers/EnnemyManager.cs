using UnityEngine;
using System.Collections;

[System.Serializable]
public struct SpawnPool
{
	public ObjectPool pool;
	public int numberToSpawn;
	public int distanceSpawn;
	public float Ydistance; 
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
			spawnPosition.y += ennemyPools[i].Ydistance;
			for (int j = 0; j < ennemyPools[i].numberToSpawn; j++) 
			{
				ennemyPools[i].pool.Spawn(spawnPosition, Quaternion.Euler (spwanRotation));

				spawnPosition += Vector3.left * ennemyPools[i].distanceSpawn;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
