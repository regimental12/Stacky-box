using UnityEngine;
using System.Collections;

public class resumeButton : MonoBehaviour {

    public GameObject pb;

	// Use this for initialization
	void Start () {

        pb = GameObject.Find("PauseButton");
        
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        pb.GetComponent<PauseButton>().paused = false;
        pb.GetComponent<PauseButton>().noGUI = true;
        Time.timeScale = 1.0f;
        Destroy(this.gameObject);
    }
}
