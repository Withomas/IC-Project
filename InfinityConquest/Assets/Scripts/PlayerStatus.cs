using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour, IKillable {

	//public GameObject Bullet;
	public GameObject Laser;

	public Transform RightFire;
	public Transform LeftFire;

	private int PointsDevie = 0;
	private int Equipe = 0;
	private int Arme = 0;
	private RaycastHit ObjetTouche;
	private float shotSpeed = 1000000.0f;

	// Update is called once per frame
	void Update () {

		//Dans le cas où le joueur clique sur le bouton droit
		if (Input.GetMouseButtonDown(0))
		{
			// Tire des lasers
			Fire ();
		}
	}

	public void Damage(int damage)
	{
		this.PointsDevie = PointsDevie - damage;
	}

	private void Fire()
	{
		GameObject laserRight = Instantiate (Laser as GameObject);
		GameObject laserLeft = Instantiate (Laser as GameObject);

		LaserBehavior laserBehaviorRight = laserRight.GetComponent<LaserBehavior> ();
		LaserBehavior laserBehaviorLeft = laserLeft.GetComponent<LaserBehavior> ();

		laserRight.transform.position = RightFire.position;
		laserRight.transform.rotation = RightFire.rotation;

		laserLeft.transform.position = LeftFire.position;
		laserLeft.transform.rotation = LeftFire.rotation;

		laserBehaviorRight.Shooted = true;
		laserBehaviorLeft.Shooted = true;
	}

}
