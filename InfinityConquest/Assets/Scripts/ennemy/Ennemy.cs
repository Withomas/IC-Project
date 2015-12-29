using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	public float speed;
	public int lifePoints;

	public GameObject player;
	public GameObject ennemyFlag;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player == null) {
			Debug.Log ("something went wrong while fetching player");
		}

		ennemyFlag = GameObject.Find ("Drapeau_Ennemi");
		if (ennemyFlag == null) {
			Debug.Log ("something went wrong while fetching ennemy flag");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// launch the ship once it is ready
	private void launch()
	{

	}
}
