using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour, IKillable {

	//public GameObject Bullet;
	public GameObject Laser;
	public Transform BulletPosition;

	private int PointsDevie = 0;
	private int Equipe = 0;
	private int Arme = 0;
	private RaycastHit ObjetTouche;
	private float shotSpeed = 1000000.0f;
	// Update is called once per frame
	void Update () {

		//Tire d'un laser
		if (Input.GetMouseButtonDown(0))
		{
			GameObject laser = Instantiate (Laser as GameObject);
			LaserBehavior laserBehavior = laser.GetComponent<LaserBehavior> ();
			BulletPosition = transform.Find("PositionProjectile");
			laser.transform.position = BulletPosition.position;
			laser.transform.rotation = BulletPosition.rotation;
			laserBehavior.Shooted = true;
		}
	}

	public void Damage(int damage)
	{
		this.PointsDevie = PointsDevie - damage;
	}

}
