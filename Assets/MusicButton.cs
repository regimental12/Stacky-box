using UnityEngine;
using System.Collections;

public class MusicButton : MonoBehaviour {

    public GameManager gm;
	// Use this for initialization
	void Start () 
    {
        gm = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

	void OnMouseDown()
	{
        gm.toggleMusic();
	}

	void toggleMusic()
	{
        
	}
}
