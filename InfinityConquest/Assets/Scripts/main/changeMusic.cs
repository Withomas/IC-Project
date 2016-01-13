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

        switch (level)
        {			
			case 1:
				source.Stop();
	            source.clip = level1Music;
	            source.Play();
	            break;

            case 5:
				source.Stop();
				source.clip = level2Music;
                source.Play();
                break;
			case 4:
				source.clip = GameOverMusic;
				source.Play();
				break;
			case  6:
				source.clip = WinMusic;
				source.Play();
				break;

            default:
                break;
        }

	}
}
