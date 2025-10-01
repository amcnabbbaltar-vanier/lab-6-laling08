using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;
    // Start is called before the first frame 

    void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.scoreText.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
