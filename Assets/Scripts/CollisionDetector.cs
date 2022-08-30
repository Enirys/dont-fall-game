using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detects collision between grid and shape (Player)

public class CollisionDetector : MonoBehaviour {

    GameManager gm;
    public GameObject deathEffect;
    //public Material dead;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            //Debug.Log("Dead");
            //collision.gameObject.GetComponent<MeshRenderer>().material = dead;
            //ralenti
            Instantiate(deathEffect, transform.position, Quaternion.identity); //Spawns Death effect
            gm.gameOver = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Empty")
        {
            //Debug.Log("Scored");
            gm.scored = true;
        }
    }
}
