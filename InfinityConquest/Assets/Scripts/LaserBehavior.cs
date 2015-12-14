using UnityEngine;
using System.Collections;

public class LaserBehavior : MonoBehaviour {

	public bool Shooted;

	LineRenderer _line;
	private float _LifeTime = 5.0f;
	private float _speed = 1000.0f;
		
	void Awake()
	{
		this._line = base.gameObject.GetComponent<LineRenderer> (); 
		Debug.logger.Log ("Laser Awake");
		Destroy (this.gameObject, _LifeTime);
	}
	void Start()
	{
		Debug.logger.Log ("Laser Started");
	}

	public void Fire()
	{
		FireLaser();
	}
		
	private void FireLaser()
	{
		Debug.logger.Log ("Laser tiré à la position  : " + transform.position + " rotation : " + transform.rotation);
		this.Shooted = true;
	}

	void Update()
	{	
		if (this.Shooted) {
			//Puis on l'envoi
			transform.Translate(Vector3.forward * Time.deltaTime * _speed);	
		}

	}


}
