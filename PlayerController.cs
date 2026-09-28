using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 1;
    float sc = 0.3162f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
            key = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
            key = -1;
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(sc * key, sc, sc);
        }

        
    }
}

//THIS CODE IS NOT WRITTEN BY ME. This code is used courtesy of @foxqstm on Github.
//Please go follow them!