using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color color = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = color;      
    }

}
