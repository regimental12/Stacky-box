using UnityEngine;
using System.Collections;

public class scoreManager : MonoBehaviour {

    public Font font;

    public int score = 0;
    void OnGUI()
    {
        GUI.skin.font = font;
        GUI.color = Color.black;
        GUI.Label(new Rect(0 , 0 , 150, 50 ), "Score: " + score);
    }
	
}
