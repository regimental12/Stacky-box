using UnityEngine;
using System.Collections;

public class deathTrigger : MonoBehaviour {
    
    public bool haslost = false;
	public Color textColor;
    public GUIStyle mystyle;

	void OnTriggerEnter2D()
    {
        Debug.Log("trigger");
        haslost = true;
    }

    void OnGUI()
    {
        GUI.backgroundColor = Color.clear;
        
        if (haslost)
        {
            GUI.skin.label.fontSize = 50;
			GUI.color = textColor;
            GUI.Label(new Rect((Screen.width / 2) -100 , (Screen.height / 2) - 25, 300, 70), "GAME OVER!");
            
            if (GUI.Button(new Rect(Screen.width/2 - 70, Screen.height/2+50, 100, 50), "RESTART" ,mystyle ))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 40 , Screen.height / 2 + 150, 100, 50), "QUIT" , mystyle))
            {
                Application.LoadLevel("MainMenu");
            }
        }
    }
}
