using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawn a grid every startTimeBtwSpawn seconds

public class GridSpawner : MonoBehaviour {

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;

    public GameObject grid;

	// Update is called once per frame
	void Update ()
    {
	    if(timeBtwSpawn <= 0)
        {
            Instantiate(grid, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
	}
}
