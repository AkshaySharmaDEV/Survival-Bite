using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Use this for initialization  
    void Start()
    {

    }

    public float speed = 0.05f;

    
    







    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.05f, 0f, 0f);
        }
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0.0f, 0f, -0.05f);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(0.0f, 0f, 0.05f);


        //}

        if (Input.GetKey(KeyCode.LeftShift))
        {

            speed = 0.12f;


        }
        else
        {
            speed = 0.05f;
        }

        



    }

}