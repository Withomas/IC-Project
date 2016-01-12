using UnityEngine;
using System.Collections;

public class changeMusic : MonoBehaviour {

    public AudioClip level1Music;
    public AudioClip level2Music;
    public AudioClip OptionMusic;
	public AudioClip MusicMenu;

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

        switch (level)
        {
            case 1 :
                source.clip = level1Music;
                source.Play();
                break;

            case 2:
                source.clip = OptionMusic;
                source.Play();
                break;

            default:
                break;
        }

	}
}
