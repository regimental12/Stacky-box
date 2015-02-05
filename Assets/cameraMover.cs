using UnityEngine;
using System.Collections;

public class cameraMover : MonoBehaviour {

    public float targetY = 0f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Lerp(transform.position.y, targetY, 1 * Time.deltaTime);
        transform.position = pos;
    }
}
