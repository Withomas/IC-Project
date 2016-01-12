using UnityEngine;
using System.Collections;

public class MapManagerScript : MonoBehaviour {

	public GameObject Player;
	public GameObject EnnemyFlag;
	public GameObject AlliesFlag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Récupération des positions
		Vector3 playerPosition = Player.transform.position;
		Vector3 ennemyFlagPosition = EnnemyFlag.transform.position;
		Vector3 alliesFlagPosition = AlliesFlag.transform.position;



	}
}
