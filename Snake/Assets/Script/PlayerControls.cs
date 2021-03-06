﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public Sprite VulvaOne;
    public Sprite VulvaTwo;

    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       Debug.Log("Hello world!");
       if (DataController.GetVulvaType() == 2) {
         this.gameObject.GetComponent<SpriteRenderer>().sprite = VulvaTwo;
       }
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = new Vector2(15, rb.velocity.y);
       onGround = Physics2D.OverlapCircle(rb.position, groundCheckRadius, whatIsGround);

       if (Input.GetMouseButtonDown(0) && onGround) {
         rb.velocity = new Vector2(rb.velocity.x, 15);
       }
        
    }
}
