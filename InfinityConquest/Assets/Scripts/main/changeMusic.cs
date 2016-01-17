using UnityEngine;
using System.Collections;

public class changeMusic : MonoBehaviour {

    public AudioClip level1Music;
    public AudioClip level2Music;
    public AudioClip OptionMusic;
	public AudioClip MusicMenu;
	public AudioClip GameOverMusic;
	public AudioClip WinMusic;
    private AudioSource source;


	// Use this for initialization
	void Awake () {
        source = GetComponent<AudioSource>();
	}
	void Start()
	{
		source.clip = MusicMenu;
		source.Play ();

	}

	void OnLevelWasLoaded (int level) {
		if (level != 0 && level != 7) {
			source.Stop();
		}

	}
}
