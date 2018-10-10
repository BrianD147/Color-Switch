using UnityEngine;

public class Rotator : MonoBehaviour {

    private static float lowerSpeed = 50; // Lower floor value possible for speed
    private static float upperSpeed = 100; // Upper ceiling value possible for speed

    private int playerScore;
    private int direction;

    public float speed; // Speed at which the circle will rotate

    private void Start()
    {
        playerScore = GameObject.Find("Player").GetComponent<Player>().getScore();
        SpawnSpeed();
        Direction();
        Debug.Log(speed);
    }

    void Update () {
        transform.Rotate(0f, 0f, speed * Time.deltaTime); // Rotate the circle about the z-axis
	}

    void SpawnSpeed()
    {
        lowerSpeed = 50 + (playerScore * 2);
        upperSpeed = 100 + (playerScore * 2);
        speed = Random.Range(lowerSpeed, upperSpeed);
    }

    void Direction()
    {
        direction = Random.Range(1,3);
        if (direction == 2)
        {
            speed *= -1;
        }
    }
}
