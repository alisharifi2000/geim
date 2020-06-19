﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerRight : MonoBehaviour
{
    bool GameHasEnded = false;
    public void GameOver()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}