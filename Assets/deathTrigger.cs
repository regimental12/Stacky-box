using UnityEngine;
using System.Collections;

public class deathTrigger : MonoBehaviour {
    public bool haslost = false;


	void OnTriggerEnter2D()
    {
        Debug.Log("trigger");
        haslost = true;
    }

    void OnGUI()
    {
        if (haslost)
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "GAME OVER");
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 35, 100, 50), "RESTART"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
