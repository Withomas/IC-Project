using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	public float speed;
	public int lifePoints;

	public GameObject player;
	public GameObject playerFlag;

	protected Rigidbody rb;
	protected int currentLifePoint;

	// Use this for initialization
	void Start () {
		initalisation ();
	}

	void OnEnable()
	{
		Debug.Log ("enabling");
		reset ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	protected void initalisation()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player == null) {
			Debug.Log ("something went wrong while fetching player");
		}

		playerFlag = GameObject.Find ("Drapeau_Gentil");
		if (playerFlag == null) {
			Debug.Log ("something went wrong while fetching ennemy flag");
		}

		rb = GetComponent<Rigidbody> ();

		currentLifePoint = lifePoints;
	}

	public void reset()
	{
		currentLifePoint = lifePoints;
	}

	// launch the ship once it is ready
	private void launch()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PlayerLaser") {
			Debug.Log ("ouch");
			currentLifePoint--;
			if (currentLifePoint <= 0) {
				Die ();
			}
		}
	}

	public void Die()
	{
		gameObject.SetActive (false);
	}
}
