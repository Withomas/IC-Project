using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	public float speed;
	public int lifePoints;

	public float maxRotationSpeed;

	public GameObject player;
	public DrapeauBehavior playerFlag;
	public DrapeauBehavior ennemyFlag;
	public TeamBase ennemyBase;

	protected Rigidbody rb;
	protected int currentLifePoint;

	protected bool hasFlag 
	{
		get {
			return GetComponent<AccrocheVaisseau> ().hasFlag;
		}
		set{
			GetComponent<AccrocheVaisseau> ().hasFlag = value;
		}
	}

	// Use this for initialization
	void Start () {
		initalisation ();
	}

	void OnEnable()
	{
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

		playerFlag = GameObject.Find ("Drapeau_Gentil").GetComponent<DrapeauBehavior> ();
		if (playerFlag == null) {
			Debug.Log ("something went wrong while fetching player flag");
		}

		ennemyFlag = GameObject.Find ("Drapeau_Ennemi").GetComponent<DrapeauBehavior> ();
		if (ennemyFlag == null) {
			Debug.Log ("something went wrong while fetching ennemy flag");
		}

		ennemyBase = GameObject.Find ("ennemyBase").GetComponent<TeamBase> ();
		if (ennemyBase == null) {
			Debug.Log ("something went wrong while fetching ennemy base");
		}

		rb = GetComponent<Rigidbody> ();
		if (rb == null) {
			Debug.Log ("something went wrong while fetching the rigidbody");
		}

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
		if (hasFlag) {
			playerFlag.Detach();
		}

		gameObject.SetActive (false);
	}

	protected Vector3 getTargetDirection(Vector3 targetPosition)
	{
		return targetPosition - transform.position;
	}

	protected Quaternion GetRotationToTarget (Vector3 targetPosition)
	{
		Quaternion rotation = Quaternion.LookRotation(getTargetDirection(targetPosition));

		return Quaternion.Slerp (transform.rotation, rotation, maxRotationSpeed * Time.deltaTime);
	}
}
 