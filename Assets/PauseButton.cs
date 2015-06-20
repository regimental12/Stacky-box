using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour {


    public GameObject ResumeButton1;
    //public GameObject musicButton;
    //public GameObject quitButton;
    public GameObject resumeClone/*, musicClone, quitClone*/;
    
    public bool paused;
    public bool noGUI = false;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	    
        if(noGUI)
        {
            destroyGUI();
            Time.timeScale = 1.0f;
        }
	}

    void OnMouseDown()
    {
        togglePause();
        if (paused)
        {
            Time.timeScale = 0.0f;
            
        }
        else
        {
            Time.timeScale = 1.0f;
        }
        
    }

    bool togglePause()
    {
        if(paused == false)
        {
            noGUI = false;
            buildGUI();
            return paused = true;
        }
        else 
        {
            return paused = false;
        }
    }

    void buildGUI()
    {
        
        resumeClone = Instantiate(ResumeButton1.transform, ResumeButton1.transform.position, ResumeButton1.transform.rotation) as GameObject;
        /*musicClone = Instantiate(musicButton.transform, musicButton.transform.position, musicButton.transform.rotation) as GameObject;
        quitClone = Instantiate(quitButton.transform, quitButton.transform.position, quitButton.transform.rotation) as GameObject;*/
    }

    void destroyGUI()
    {
        //Destroy(resumeClone.gameObject);
        /*DestroyImmediate(musicButton , true);
        DestroyImmediate(quitButton , true);*/
    }

    
}
