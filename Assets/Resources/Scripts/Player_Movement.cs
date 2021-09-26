﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Vector2 Speed;
    private Rigidbody2D PlayerRB;
    public float JumpHeight;
    public bool OnGround;
    // Start is called before the first frame update
    void Start()
    {
        this.PlayerRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(this.Speed.x * inputX, 0, 0);
        if(this.OnGround && Input.GetKey(KeyCode.Space))
        {
            PlayerRB.AddForce(Vector2.up * this.JumpHeight * 9.8f);
            this.OnGround = false;
        }
        movement.y = this.transform.position.y;

        transform.Translate(movement * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            this.OnGround = true;
        }
    }
}
