using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float jumpForce; // Amount of forced added to players upward direction
    public string currentColor; // The current player color

    public Rigidbody2D rb; // players Rigidbody
    public SpriteRenderer sr; // player sprite renderer

    public Color colorCyan; // cyan color for sprite
    public Color colorYellow; // yellow color for sprite
    public Color colorMagenta; // magenta color for sprite
    public Color colorPink; // pink color for sprite

    public int score; // players score
    public Text scoreText; // players score as presented on screen

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
                currentColor = "Cyan"; // Set currentColor
                sr.color = colorCyan; // Set sprite to be cyan
                break;
            case 1:
                currentColor = "Yellow"; // Set currentColor
                sr.color = colorYellow; // Set sprite to be yellow
                break;
            case 2:
                currentColor = "Magenta"; // Set currentColor
                sr.color = colorMagenta; // Set sprite to be magenta
                break;
            case 3:
                currentColor = "Pink"; // Set currentColor
                sr.color = colorPink; // Set sprite to be pink
                break;
        }
    }

    void Update () {
        if (Input.touchCount > 0)
        {
            rb.bodyType = RigidbodyType2D.Dynamic; // Set rigidbody to dynamic
            Touch touch = Input.GetTouch(0); // Get
            if (touch.phase.Equals(TouchPhase.Began)) // When the current touch began
            {
                rb.velocity = Vector2.up * jumpForce; // Apply jumpForce to the players upwards direction
            }
        }
        

        if (Input.GetKeyDown(KeyCode.Space)) // When spacebar is pressed
        {
            rb.bodyType = RigidbodyType2D.Dynamic; // Set rigidbody to dynamic
            rb.velocity = Vector2.up * jumpForce; // Apply jumpForce to the players upwards direction
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) // When up arrow is pressed
        {
            rb.bodyType = RigidbodyType2D.Dynamic; // Set rigidbody to dynamic
            rb.velocity = Vector2.up * jumpForce; // Apply jumpForce to the players upwards direction
        }

        if (Input.GetMouseButtonDown(0)) // When left mouse button is pressed
        {
            rb.bodyType = RigidbodyType2D.Dynamic; // Set rigidbody to dynamic
            rb.velocity = Vector2.up * jumpForce; // Apply jumpForce to the players upwards direction
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

        if (col.tag == "Score") // If collision is with the score tag
        {
            score++; // Add 1 to score
            scoreText.text = score.ToString(); // Set the scoreText to scores new value
            Destroy(col.gameObject); // Destroy the score gameobject
            return; // Exit the function
        }

        if (col.tag != currentColor) // If the collision is with the wrong color
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Load the same scene from the beginning (temporary)
        }
    }
}
