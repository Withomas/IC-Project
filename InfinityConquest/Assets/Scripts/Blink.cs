using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {

	public Light BlinkingLight;
	public float MaxIntensity = 4.0f;
	public float MinIntensity = 0.0f;

	private int factor;
	private bool GoingUp;
	// Use this for initialization
	void Start () 
	{
		BlinkingLight.intensity = MinIntensity;
		GoingUp = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GoingUp) {
			BlinkingLight.intensity += 0.1f;
		} else {
			BlinkingLight.intensity -= 0.1f;
		}

		if ((BlinkingLight.intensity >= MaxIntensity) && GoingUp) {
			GoingUp = false;
		} 

		if ((BlinkingLight.intensity <= MinIntensity) && !GoingUp) {
			GoingUp = true;
		}
		Debug.Log (BlinkingLight.intensity.ToString());
	}
}
