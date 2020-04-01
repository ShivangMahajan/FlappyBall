using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D rg;
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            touch = Input.GetTouch(0);
        }
        //moveForward();
        if (Input.GetKeyDown(KeyCode.Space) || touch.phase == TouchPhase.Began)
        {
            Jump();
        }
    }

    private void moveForward()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //rg.velocity = Vector2.right * speed;
    }

    private void Jump()
    {
        rg.AddForce(Vector2.up * 250);
    }

}
