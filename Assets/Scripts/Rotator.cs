using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rotates shape

public class Rotator : MonoBehaviour {

    // Update is called once per frame
    void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.Rotate(new Vector3(0,0,90));
        }
	}
}
