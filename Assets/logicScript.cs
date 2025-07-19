using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

   public void restartGame()
{
    Debug.Log("Restart button clicked");
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}


    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
