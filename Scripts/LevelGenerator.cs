using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject obstacle;
    public int poolSize = 6;
    public float spawnRate = 4;

    private float lastTime;
    private StartGame startGame;
    private GameObject[] obstacles;
    private int currentObstacle;
    private int obsctaclesGenerated;
    private float timeToDecreaseSR;
    Vector2 objectPool = new Vector2(-20, -20);
    // Start is called before the first frame update
    void Start()
    {
        timeToDecreaseSR = 0;
        obsctaclesGenerated = 0;
        startGame = GameObject.Find("Start Game").GetComponent<StartGame>();
        currentObstacle = 0;
        lastTime = 0;
        obstacles = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            obstacles[i] = Instantiate(obstacle, objectPool, Quaternion.identity);
            obsctaclesGenerated++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lastTime += Time.deltaTime;

        if (lastTime >= spawnRate && startGame.isAlive)
        {
            lastTime = 0;
            obstacles[currentObstacle].transform.position = new Vector2(Random.Range(11.18f, 13.5f), Random.Range(0.0f, 4.88f));
            currentObstacle++;
            if (currentObstacle > poolSize-1)
                currentObstacle = 0;
        }

        timeToDecreaseSR += Time.deltaTime;
        if (timeToDecreaseSR >= 30f && startGame.isAlive && spawnRate > 1.5f)
        {
            spawnRate -= 0.5f;
            timeToDecreaseSR = 0;
        }


        if (!startGame.isAlive)
        {
            for (int i = 0; i < obsctaclesGenerated; i++)
            {
                Destroy(obstacles[i]);
            }
            Destroy(this.gameObject);
        }
    }

}
