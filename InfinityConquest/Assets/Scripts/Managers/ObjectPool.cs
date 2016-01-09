using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Class : ObjectPool
// Description : class managing object pools

public class ObjectPool : MonoBehaviour 
{
	public GameObject[] prefabs;
	public int numberOfObjectsAtInit = 0;

	List<GameObject> objects;

	void Start ()
	{
		objects = new List<GameObject>(numberOfObjectsAtInit);
		addInPool(numberOfObjectsAtInit);
	}

	// Procedure : addInPool
	// Description : add objects in the prefabs array in the pool, those objects are deactivate
	// Parameters :
	// 		numberOfObjectToInstantiate (int) is the number of objects to instantiate

	private void addInPool(int numberOfObjectToInstantiate = 1)
	{
		for(int i = 0; i < numberOfObjectToInstantiate; i++)
		{
			objects.Add(Instantiate(prefabs[Random.Range(0, prefabs.Length)], Vector3.zero, Quaternion.identity) as GameObject);
			objects[objects.Count - 1].gameObject.SetActive(false);
		}
	}

	// Function : addInPoolActive
	// Description : add objects in the prefabs array in the pool, those objects are activate and place in a position
	// Parameters :
	// 		position is the position of the first object
	// 		numberOfObjectToInstantiate is the number of objects to instantiate
	//			if numberOfObjectToInstantiate is lower than 1, the function does nothing and returns a vector equal to (0.0f, 0.0f)
	//			if numberOfObjectToInstantiate is higher than 1, each objects are spawned side by side

	private void addInPoolActive(Vector3 position, int numberOfObjectToInstantiate = 1)
	{
		for(int i = 0; i < numberOfObjectToInstantiate; i++)
		{
			objects.Add(Instantiate(prefabs[Random.Range(0, prefabs.Length)], position, Quaternion.identity) as GameObject);
			objects[objects.Count - 1].gameObject.SetActive (true);
		}
	}

	private void addInPoolActive(Vector3 position, Quaternion rotation, int numberOfObjectToInstantiate = 1)
	{
		for(int i = 0; i < numberOfObjectToInstantiate; i++)
		{
			objects.Add(Instantiate(prefabs[Random.Range(0, prefabs.Length)], position, rotation) as GameObject);
			objects[objects.Count - 1].gameObject.SetActive (true);
		}
	}
		
	// Function : Spawn
	// Description : Spawn any number of objects of the object pool at the specified position.
	//				 If there is not enougth disable objects on the pool, the pool is scale up
	//				 
	// Parameters :
	// 		spawnPosition is the position of the first object
	// 		number is the number of objects to create
	//			if number is lower than 1, the function does nothing and returns a vector equal to (0.0f, 0.0f)
	//			if number is higher than 1, each objects are spawned side by side
	
	public void Spawn(Vector3 spawnPosition, int number = 1)
	{
		if(number < 1)
		{
			return;
		}
		
		foreach(GameObject obj in objects)
		{
			if(obj.activeSelf == false)
			{
				obj.gameObject.SetActive (true);
				obj.gameObject.transform.position = spawnPosition;

				number--;
				if(number < 1)
				{
					return;
				}
			}
		}
		
		//if the programm is at this state, then there is no more objects usable on the scene
		addInPoolActive(spawnPosition, number);
	}

	public void Spawn(Vector3 spawnPosition, Quaternion spawnRotation, int number = 1)
	{
		if(number < 1)
		{
			return;
		}

		foreach(GameObject obj in objects)
		{
			if(obj.activeSelf == false)
			{
				obj.gameObject.SetActive (true);
				obj.gameObject.transform.position = spawnPosition;
				obj.gameObject.transform.rotation = spawnRotation;

				number--;
				if(number < 1)
				{
					return;
				}
			}
		}

		//if the programm is at this state, then there is no more objects usable on the scene
		addInPoolActive(spawnPosition, spawnRotation, number);
	}

	// Procedure : Reset
	// Description : deactivate each object of the pool

	public void Reset()
	{
		foreach(GameObject obj in objects)
		{
			obj.SetActive(false);
		}
	}
}
