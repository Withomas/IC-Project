using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	public float speed;
	public int lifePoints;

	public float maxRotationSpeed;

	public float shootDistance;
	public float chaseDistance;
	public float shootDelay; // in seconds

	public GameObject player;
	public DrapeauBehavior playerFlag;
	public DrapeauBehavior ennemyFlag;
	public TeamBase ennemyBase;

	public GameObject laser;

	public GameObject shootSpawnLeft;
	public GameObject shootSpawnRight;

	protected Rigidbody rb;
	protected int currentLifePoint;
	protected bool canShoot = true;

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
		canShoot = true;
	}

	// launch the ship once it is ready
	private void launch()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Laser") 
		{
			if (other.gameObject.layer != 9) {
				currentLifePoint--;
				if (currentLifePoint <= 0) {
					Die ();
				}
			}

		}
	}

	public void Die()
	{
		if (hasFlag) {
			playerFlag.Detach();
		}

		gameObject.SetActive (false);
		//yield return new WaitForSeconds(Random.Range(5f,15f));
		ResetEnnemy ();
	}

	protected void ResetEnnemy()
	{
		transform.position = ennemyBase.transform.position;
		gameObject.SetActive (true);
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

	protected float getPlayerDistance()
	{
		return Vector3.Distance (transform.position, player.transform.position);
	}

	protected void Shoot()
	{
		if (canShoot)
		{
			launchLaser (shootSpawnLeft.transform);
			launchLaser (shootSpawnRight.transform);
			if (shootDelay > 0.0f) 
			{
				canShoot = false;
				reload ();

			}
		}
	}

	protected void ChasePlayer()
	{
		Vector3 playerDirection = getTargetDirection (player.transform.position);
		playerDirection.Normalize ();
		rb.velocity = playerDirection * speed;

		transform.rotation = GetRotationToTarget (player.transform.position);
	}

	protected void MoveToPlayerFlag()
	{
		Vector3 flagDirection = getTargetDirection (playerFlag.transform.position);
		flagDirection.Normalize ();
		rb.velocity = flagDirection * speed;

		transform.rotation = GetRotationToTarget (playerFlag.transform.position);
	}

	protected void MoveToBase()
	{
		Vector3 baseDirection = getTargetDirection (ennemyBase.transform.position);
		baseDirection.Normalize ();
		rb.velocity = baseDirection * speed;

		transform.rotation = GetRotationToTarget (ennemyBase.transform.position);
	}

	private void launchLaser(Transform origin)
	{
		GameObject l = Instantiate (laser as GameObject);

		LaserBehavior laserBehavior = l.GetComponent<LaserBehavior> ();

		l.transform.position = origin.position;
		l.transform.rotation = origin.rotation;

		laserBehavior.Shooted = true;
	}

	protected IEnumerator reload()
	{
		canShoot = true;
		yield return new WaitForSeconds (shootDelay);
	}
}
 