using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text scoreText; //Display in-game score text
    public Text gameOverScoreText; //Display game over score text

    public bool gameOver;

    public int score;
    public bool scored;

    public GameObject cube1;
    public GameObject gridSpawner;
    public GameObject gameOverPanel;
    public GameObject mainMenuPanel;
    public GameObject gamePanel;

    // Update is called once per frame
    void Update ()
    {
		if(gameOver)
        {
            gridSpawner.SetActive(false);
            gamePanel.SetActive(false);
            gameOverPanel.SetActive(true);
            gameOverScoreText.text = score.ToString();
        }
        else
        {
            scoreText.text = score.ToString();

            if (scored) //Update score
            {
                score++;
                scored = false;
            }
        }
	}
}
