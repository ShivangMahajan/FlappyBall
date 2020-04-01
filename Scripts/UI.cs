using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private Text scoreText;
    private TextMeshProUGUI gameoverText;
    private int highScore;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponentInChildren<Text>();
        gameoverText = GetComponentInChildren<TextMeshProUGUI>();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        gameoverText.gameObject.SetActive(false);
    }

    private void Update()
    {
       
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        if (highScore < score)
            PlayerPrefs.SetInt("HighScore", score);
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void ShowGameOver()
    {
        gameoverText.gameObject.SetActive(true);
    }
}
