using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private StartGame startGame;
    public GameObject burst;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("vcam").GetComponent<CinemachineVirtualCamera>().Follow = gameObject.transform;
        startGame = GameObject.Find("Start Game").GetComponent<StartGame>();
        startGame.isAlive = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gameObject.SetActive(false);
            Instantiate(burst, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject, 3f);
            startGame.lateIsAlive = false;
        }
    }
}
