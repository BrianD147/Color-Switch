using System;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float jumpForce; // Amount of forced added to players upward direction

    private string currentColor; // The current player color

    Rigidbody2D rb; // players Rigidbody

    void Start() {
        rb = GetComponent<Rigidbody2D>(); // linking player Rigidbody to rb

        SetRandomColor(); // call SetRandomColor()
    }

   void SetRandomColor() // used to set the currentColor to either Cyan, Yellow, Magenta or Pink
    {
        int index = Random.range(0, 3); // index int which can have any value from 0 - 3 (4 options)

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                break;
            case 1:
                currentColor = "Yellow";
                break;
            case 2:
                currentColor = "Magenta";
                break;
            case 3:
                currentColor = "Pink";
                break;
        }
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) // When spacebar is pressed
        {
            rb.velocity = Vector2.up * jumpForce; // apply jumpForce to the players upwards direction
        }
	}

    void OnTriggerEnter2D(Collider2D col) // When a collision occurs
    {
        if (col.tag == "Yellow") // If the collision is with the yellow hitbox
        {

        }
    }
}
