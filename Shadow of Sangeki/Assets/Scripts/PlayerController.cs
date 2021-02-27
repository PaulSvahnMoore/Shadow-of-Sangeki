using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;
    private float moveInput;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}