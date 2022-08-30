using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Change Main Camera color 

public class CameraColor : MonoBehaviour {

    public Color[] colors;
    private Camera mainCam;

    private int c = 1;
    public GameManager gm;

	// Use this for initialization
	void Start ()
    {
        mainCam = GetComponent<Camera>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(gm.score >= c * 5)
        {
            int randColor = Random.Range(0, colors.Length);
            mainCam.backgroundColor = colors[randColor];
            c++;
        }
	}
}
