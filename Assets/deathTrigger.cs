using UnityEngine;
using System.Collections;

public class deathTrigger : MonoBehaviour {
    
    public bool haslost = false;
	public Color textColor;

	void OnTriggerEnter2D()
    {
        Debug.Log("trigger");
        haslost = true;
    }

    void OnGUI()
    {
        if (haslost)
        {
            GUI.skin.label.fontSize = 36;
			GUI.color = textColor;
            GUI.Label(new Rect((Screen.width / 2) -70 , (Screen.height / 2) - 25, 200, 50), "GAME OVER!");
            GUI.color = Color.white;
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 35, 100, 50), "RESTART"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
