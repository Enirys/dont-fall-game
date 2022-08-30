using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawn item from itemPrefabs array (cube or empty object) in spawn Point position

public class SpawnElements : MonoBehaviour {
    
    public GameObject[] itemPrefabs; //Array of items (cube or empty) object
    public GameObject cubePrefab; //Cube prefab
    Vector3 spawnPosition; //Position of shape
    Transform parent; //Parent object of shape

	// Use this for initialization
	void Start ()
    {
        spawnPosition = new Vector3(transform.position.x, transform.position.y, 150);
        int randItem = Random.Range(0, itemPrefabs.Length);
        Instantiate(itemPrefabs[randItem], transform.position, Quaternion.identity);
        parent = GameObject.Find("Parent").transform;
        if(randItem == 0)
        {
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity,parent);
        }

    }
}
