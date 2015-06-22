using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public bool playing;
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
        playing = true;
    }

    public void toggleMusic()
    {
        if(playing)
        {
            music.Stop();
            playing = false;
        }
        else
        {
            music.Play();
            playing = true;
        }

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
	
}
