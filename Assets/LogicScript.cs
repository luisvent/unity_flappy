using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject bird;
    public int playerScore = 0;
    public Text scoreText;

    [ContextMenu("Add Score")]
    public void AddScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Dead();
    }

    private void Dead()
    {
        bird.SetActive(false);
    }

    public void Restart()
    {
        gameOverScreen.SetActive(false);
        bird.SetActive(true);
        playerScore = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
