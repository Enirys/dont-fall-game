using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawn elementSpawnerPrefab (Spawns a random object from an array)

public class ElementSpawner : MonoBehaviour {

    public GameObject elementSpawnerPrefab;

	// Use this for initialization
	void Start ()
    {
        Instantiate(elementSpawnerPrefab, transform.position, Quaternion.identity);
	}
}
