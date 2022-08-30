using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scene Transitions

public class Scene : MonoBehaviour {

    public GameManager gm;

    public void LoadGame() //Start the Game
    {
        gm.gridSpawner.SetActive(true);
        gm.gamePanel.SetActive(true);
        gm.mainMenuPanel.SetActive(false);
    }

    public void Replay() //Reload the Scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
