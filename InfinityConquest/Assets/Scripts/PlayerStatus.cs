using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour, IKillable {

	public GameObject Bullet;
	public Transform BulletPosition;

	private int PointsDevie = 0;
	private int Equipe = 0;
	private int Arme = 0;
	private RaycastHit ObjetTouche;
	private float shotSpeed = 10.0f;
	// Update is called once per frame
	void FixedUpdate () {
	
		//Tire d'un laser
		if (Input.GetMouseButton(0))
		{
			BulletPosition = transform.Find("PositionProjectile");
			GameObject ball = (GameObject) Instantiate(Bullet,BulletPosition.position,BulletPosition.rotation);

			Rigidbody rb = ball.GetComponent<Rigidbody>();
			if (rb != null) {
				rb.AddForce(BulletPosition.forward * shotSpeed * Time.deltaTime);
				Destroy(ball, 5);
			}
		}
	}

	public void Damage(int damage)
	{
		this.PointsDevie = PointsDevie - damage;
	}

}
