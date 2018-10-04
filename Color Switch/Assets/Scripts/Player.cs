using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float jumpForce; // Amount of forced added to players upward direction
    public string currentColor; // The current player color

    public Rigidbody2D rb; // players Rigidbody
    public SpriteRenderer sr; // player sprite renderer

    public Color colorCyan; // cyan color for sprite
    public Color colorYellow; // yellow color for sprite
    public Color colorMagenta; // magenta color for sprite
    public Color colorPink; // pink color for sprite

    void Start() {
        rb = GetComponent<Rigidbody2D>(); // linking player Rigidbody to rb
        SetRandomColor(); // call SetRandomColor()
    }

   void SetRandomColor() // used to set the currentColor to either Cyan, Yellow, Magenta or Pink
    {
        int index = UnityEngine.Random.Range(0, 4); // index int which can have any value from 0 - 3 (4 options)

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan; // set sprite to be cyan
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow; // set sprite to be yellow
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta; // set sprite to be magenta
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink; // set sprite to be pink
                break;
        }
    }

    void Update () {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase.Equals(TouchPhase.Began))
            {
                rb.velocity = Vector2.up * jumpForce; // apply jumpForce to the players upwards direction
            }
        }
        

        if (Input.GetKeyDown(KeyCode.Space)) // When spacebar is pressed
        {
            rb.velocity = Vector2.up * jumpForce; // apply jumpForce to the players upwards direction
        }
	}

    void OnTriggerEnter2D(Collider2D col) // When a collision occurs
    {
        if(col.tag == "ColorChanger") // If the collision is with the colorChanger
        {
            SetRandomColor(); // Change the color
            Destroy(col.gameObject); // Destroy the colorChanger object
            return; // Exit the function
        }

        if (col.tag == "Score")
        {
            //Add 1 to score
            Destroy(col.gameObject);
            return;
        }

        if (col.tag != currentColor) // If the collision is with the wrong color
        {
            //Debug.Log("GAME OVER!");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
