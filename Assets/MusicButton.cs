using UnityEngine;
using System.Collections;

public class MusicButton : MonoBehaviour {

	AudioSource GM;
	//AudioSource audio;
	public bool play;

	// Use this for initialization
	void Start () {
		play = true;
		//gm = gameObject.GetComponent<GameManager> ();
		//audio = gm.gameObject.GetComponent<AudioSource> ();
		GM = GameManager.instance.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		toggleMusic ();
		if (!play) 
		{
			//gm.GetComponent<AudioSource>().Stop();
			GM.GetComponent<AudioSource>().Stop();

		} 
		else 
		{
			//gm.GetComponent<AudioSource>().Play();
			GM.GetComponent<AudioSource>().Play();
		}
	}

	void toggleMusic()
	{
		if(play)
		{
			play = false;
		}
		else
		{
			play = true;
		}

	}
}
