﻿using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float jumpForce;

    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
	}
}
