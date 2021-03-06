﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rb;
    

   private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
    }


    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Car")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

        }
    }

}
