using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private StartGame startGame;
    private float speed;
    private float timeToIncreaseSpeed;
    // Start is called before the first frame update
    void Start()
    {
        timeToIncreaseSpeed = 0f;
        speed = 2f;
        startGame = GameObject.Find("Start Game").GetComponent<StartGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x < -9.3f && transform.gameObject.tag == "HigherObstacle") || !startGame.isAlive)
            Destroy(this.gameObject);
        timeToIncreaseSpeed += Time.deltaTime;
        if (timeToIncreaseSpeed >= 45f && speed <= 6f)
        {
            speed += 0.5f;
            timeToIncreaseSpeed = 0;
            
        }
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
