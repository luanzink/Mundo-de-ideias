using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody2D player;

    public float speed;
    public float jumpForce;
   
    public GameObject groundCheck;
    public bool isGrounded;
    //public LayerMask isGround;

    public Vector2 xy;

    private Collider2D col2d;

    public GameObject pergUI;

    private bool v;

    public int vidas;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    private void Awake()
    {
        vidas = 3;
        
    }


    void Update()
    {
        if (isGrounded == true)
        {
            xy = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        }

        player.velocity = new Vector2(speed, player.velocity.y);
        if (GameObject.FindWithTag("CP") == false) {
            if (Input.GetMouseButtonDown(0) && isGrounded == true)
            {
                player.velocity = new Vector2(player.velocity.x, jumpForce);
            }
        }
    }
}
