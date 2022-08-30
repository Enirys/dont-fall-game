using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scroll objects in z-axis

public class ScrollObstacle : MonoBehaviour {

    public float moveSpeed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * moveSpeed);
	}
}
