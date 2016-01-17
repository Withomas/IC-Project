using UnityEngine;
using System.Collections;

public class TeamBaseEnemyLvl2 : MonoBehaviour {
	public GameObject PanelVie ;
	public int lifePoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter (Collider other)
	{
	if (other.gameObject.tag == "Laser") 
		{
			if (other.gameObject.layer == 8) {
				DamageBase (1);
				ReduceBarLife ();
			}
		}
	}

	private void DamageBase(int degat)
	{
		lifePoint = lifePoint - 1; 
		if (lifePoint <= 0) 
		{
			DieBase ();
			// Jeu terminé , vous avez gagné 
		}
	}

	private void DieBase (){
		gameObject.SetActive (false);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Win");
	}

	private void ReduceBarLife(){
		//PanelVie.GetComponent<RectTransform> ().anchoredPosition = new Vector2(0f, 0f);
		float widthSize = 10 * lifePoint;
		GameObject.Find ("PanelVieBaseEnemy").GetComponent<RectTransform> ().sizeDelta = new Vector2(widthSize  ,30f);

	}
}
