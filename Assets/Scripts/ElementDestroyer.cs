using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destroy GameObject after lifetime

public class ElementDestroyer : MonoBehaviour {

    public float lifeTime;

	// Update is called once per frame
	void Update ()
    {
        Destroy(gameObject, lifeTime);
	}
}
