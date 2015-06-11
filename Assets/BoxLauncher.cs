using UnityEngine;
using System.Collections;

public class BoxLauncher : MonoBehaviour 
{

    public GameObject[] boxPrefabs;

    public float fireDelay = 3f;
    public float nextFire = 1f;

    public float fireVelocity = 10f;

	
	void FixedUpdate () 
    {

        if (GameObject.FindObjectOfType<deathTrigger>().haslost)
        {
            return;
        }
        nextFire -= Time.deltaTime;

        if (nextFire <= 0)
        {
            //spawn new box
            nextFire = fireDelay;

            GameObject boxGO = (GameObject)Instantiate(boxPrefabs[Random.Range(0, boxPrefabs.Length)], transform.position, transform.rotation);

            boxGO.GetComponent<Rigidbody2D>().velocity = transform.rotation * new Vector2(0, fireVelocity);

            GameObject.FindObjectOfType<scoreManager>().score++;

            Vector3 camPos = GameObject.FindObjectOfType<cameraMover>().transform.position;
            Vector3 luancherPos = boxGO.transform.position;
            float dist = camPos.y - luancherPos.y;
            if (dist > 0.5)
            {
                fireVelocity += 1;
            }
        }
        
	}
}
