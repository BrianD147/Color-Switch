using UnityEngine;

public class Rotator : MonoBehaviour {

    private static float lowerSpeed = 50; // Lower floor value possible for speed
    private static float upperSpeed = 100; // Upper ceiling value possible for speed

    private int playerScore;
    private int direction;

    public float speed; // Speed at which the circle will rotate

    private void Start()
    {
        playerScore = GameObject.Find("Player").GetComponent<Player>().GetScore(); // Find the player GameObject and call getScore() to assign the playerScore value
        SpawnSpeed(); // call SpawnSpeed
        Direction(); // call Direction
    }

    void Update () {
        transform.Rotate(0f, 0f, speed * Time.deltaTime); // Rotate the circle about the z-axis
	}

    void SpawnSpeed()
    {
        lowerSpeed = 50 + (playerScore * 2); // set lowerSpeed floor in relation to the players score
        upperSpeed = 80 + (playerScore * 2); // set upperSpeed ceiling in relation to the players score
        speed = Random.Range(lowerSpeed, upperSpeed); // set the speed to a random number between the two ranges
    }

    void Direction()
    {
        direction = Random.Range(1,3); // set direction to either 1 or 2
        if (direction == 2)
        {
            speed *= -1; // if the number is 2, change the rotation direction
        }
    }
}
