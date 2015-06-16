using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public AudioSource music;
    private static GameManager _Instance;
    public static GameManager Instance 
    {
        get
        {
            if (Instance == null)
            {
                _Instance = GameObject.FindObjectOfType<GameManager>();
                DontDestroyOnLoad(Instance.gameObject);
            }
            return _Instance;
        }
        
    }

    void Awake()
    {
        if (_Instance == null)
        {
            _Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(this != _Instance)
            {
                Destroy(this.gameObject);
            }
        }
       
    }

    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
        music.clip = Resources.Load("Outofplace") as AudioClip;
        music.loop = true;
        music.Play();
    }

    public void toggleMusic()
    {
        
    }
	
}
