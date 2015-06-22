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
            GUI.skin.label.fontSize = 150;
            GUI.skin.label.alignment = TextAnchor.MiddleCenter;
            
			GUI.color = textColor;
            GUI.Label(new Rect((Screen.width / 2) -500 , (Screen.height / 2) - 200, 1000, 200), "GAME OVER!");
            
            
            if (GUI.Button(new Rect(Screen.width/2 -50 , Screen.height/2+150, 100, 50), "RESTART" ,mystyle ))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect(Screen.width / 2 -50 , Screen.height / 2 + 350, 100, 50), "QUIT" , mystyle))
            {
                Application.LoadLevel("MainMenu");
            }
        }
    }
}
