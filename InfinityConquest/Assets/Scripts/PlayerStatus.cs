﻿using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour, IKillable {

	//public GameObject Bullet;
	public GameObject Laser;
	public int numeroLvl = 1;
	public Transform RightFire;
	public Transform LeftFire;

	[SerializeField]
	private int PointsDevie = 0;

	private RaycastHit ObjetTouche;

	public TeamBase playerBase;
	private int ptVieTotal ;
	void Start()
	{
		Initialisation ();
		ptVieTotal = PointsDevie;
	}

	private void Initialisation()
	{
		playerBase = GameObject.Find ("playerBase").GetComponent<TeamBase> ();
		if (playerBase == null) {
			Debug.Log ("something went wrong while fetching ennemy base");
		}
	}

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

		if (PointsDevie <= 0)
		{
			Die ();

		}
		if (numeroLvl == 1) {
			GameObject.Find ("PanelPointDeVieJoueur").GetComponent<RectTransform> ().sizeDelta = new Vector2(20*PointsDevie  ,30f);
		}
	}

	private void Die()
	{
		PointsDevie = ptVieTotal;
		Respawn ();
	}

	private void Respawn()
	{
		transform.position = playerBase.transform.position;
	}

	private void Fire()
	{
		launchLaser (LeftFire);
		launchLaser (RightFire);
	}

	private void launchLaser(Transform origin)
	{
		GameObject laser = Instantiate (Laser as GameObject);

		LaserBehavior laserBehavior = laser.GetComponent<LaserBehavior> ();

		laser.transform.position = origin.position;
		laser.transform.rotation = origin.rotation;

		laserBehavior.Shooted = true;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Laser") 
		{						
			if (other.gameObject.layer != 8) {
				Damage (1);	
			}
		}
	}
}
