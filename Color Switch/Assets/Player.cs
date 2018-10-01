using System;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float jumpForce;

    private string currentColor;

    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();

        SetRandomColor();
    }

   void SetRandomColor()
    {
        int index = Random.range(0, 3);

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Yellow")
        {

        }
    }
}
