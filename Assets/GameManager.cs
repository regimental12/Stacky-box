using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	static GameManager gm;
	public AudioSource au;

	void Start()
	{
		au = gameObject.AddComponent<AudioSource> ();
		au.clip = Resources.Load ("Outofplace") as AudioClip;
		au.loop = true;
		au.Play ();
	}
	
	static public bool isActive { 
		get { 
			return gm != null; 
		} 
	}
	
	static public GameManager instance
	{
		get
		{
			if (gm == null)
			{
				gm = Object.FindObjectOfType(typeof(GameManager)) as GameManager;
				
				if (gm == null)
				{
					GameObject go = new GameObject("GameManager");
					DontDestroyOnLoad(go);
					gm = go.AddComponent<GameManager>();
				}
			}
			return gm;
		}
	}
}
