using UnityEngine;
using System.Collections;

public class collisionHandler : MonoBehaviour {

	void OnCollisionEnter2D()
    {
        Vector3 camPos = Camera.main.transform.position;
        if (camPos.y < transform.position.y)
        {
            Camera.main.GetComponent<cameraMover>().targetY = transform.position.y;
        }
        audio.Play();
    }
}
