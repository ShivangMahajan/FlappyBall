using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private UI ui;
    public GameObject player, levelGenarator;
    public bool isAlive, lateIsAlive;
    private float timeToWait;
    // Start is called before the first frame update
    void Start()
    {
        lateIsAlive = true;
        timeToWait = 0;
        ui = GameObject.Find("UI").GetComponent<UI>();
    }

    // Update is called once per frame
    void Update()
    {

       if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)&& !isAlive && lateIsAlive)
        {
            Instantiate(player, Vector2.zero, Quaternion.identity);
            isAlive = true;
            ui.ResetScore();
            Instantiate(levelGenarator, Vector2.zero, Quaternion.identity);
        }

       if (!lateIsAlive)
        {
            ui.ShowGameOver();
            timeToWait += Time.deltaTime;
            if (timeToWait > 3f)
            {
                isAlive = false;
                timeToWait = 0;
                SceneManager.LoadScene(0);
                SceneManager.UnloadSceneAsync(1);
            }
        }
    }

}
