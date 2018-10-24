using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform player; // Player transform

    bool objectSpawned = true; // Used to allow or stop objects from being spawned
    int spawnCount; // Used to determine what should be spawned
    float spawnPoint; // The position objects should be spawned from
    int spawnType; // Used to spawn different types of obstacles
    int spawnOffSet; // Used to determine which side the spawn should be offset (left or right)
    Vector3 spawnOffSetPoint; // The position objects should be spawned at an offset

    public Transform smallCircle; // Default small circle transform
    public Transform smallSquare; // Default small square transform
    public Transform smallLines; // Default small lines transform
    public Transform colorChanger; // Transform of the color changer gameobject
    public Transform scorePickup; // Transform of the score pickup gameobject
	
	void Update () {
        if (player.position.y > transform.position.y - 20) // If the players vertical position is greater than 22 below the spawners vertical position
        {
            transform.position = new Vector3(transform.position.x, player.position.y + 20, transform.position.z); // Move the spawners vertical position to match the players vertical position
        }

        if (transform.position.y % 4 < 1) // Spawning occures after a gap of 5
        {
            if (!objectSpawned) // If objectSpawned is false
            {
                objectSpawned = true; // Set objectSpawned to true (stopping any more objects spawning at this gap)
                Spawn(); // Spawn an object
            }
        }
      
        if (transform.position.y - spawnPoint > 2) // After the spawning area has been fully passed over
        {
            objectSpawned = false; // Set objectSpawned to false (allowing another object to spawn at next gap)
        }
    }

    void Spawn()
    {
        spawnPoint = transform.position.y; // Set spawnPoint to the spawners vertical position

        if (spawnCount % 2 == 0) // If spawnCount is even
        {
            spawnType = Random.Range(1, 4); // Generate a random float between 1 and 4 (parsed down into an int so will only produce 1, 2 or 3)
            if (spawnType == 1)
            {
                Instantiate(smallCircle, transform.position, transform.rotation); // Spawn a small circle
            } else if (spawnType == 2)
            {
                Instantiate(smallSquare, transform.position, transform.rotation); // Spawn a small square
            } else if (spawnType == 3)
            {
                spawnOffSet = Random.Range(1, 3);
                if (spawnOffSet == 1)
                {
                    spawnOffSetPoint = transform.position;
                    spawnOffSetPoint.x -= 2;
                    Instantiate(smallLines, spawnOffSetPoint, transform.rotation); // Spawn a small lines to the left
                }
                else
                {
                    spawnOffSetPoint = transform.position;
                    spawnOffSetPoint.x += 2;
                    Instantiate(smallLines, spawnOffSetPoint, transform.rotation); // Spawn a small lines to the right
                }
            }

            Instantiate(scorePickup, transform.position, transform.rotation); // Spawn a scorePickup
        }
        else // If spawnCount is odd
        {
            Instantiate(colorChanger, transform.position, transform.rotation); // Spawn a colorChanger
        }

        spawnCount++; // Increment spawnCount
    }
}
