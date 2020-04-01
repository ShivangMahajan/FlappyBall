using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public TextMeshProUGUI hs ;
    private int HighScore;
    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log("" + HighScore);
        hs.text = "High Score: " + HighScore;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
