using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform player;

    bool objectSpawned = true;
    int spawnCount;
    float spawnPoint;

    public Transform circle;
    public Transform colorChanger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.position.y > transform.position.y - 20) // If the players vertical position is greater than 22 below the spawners vertical position
        {
            transform.position = new Vector3(transform.position.x, player.position.y + 20, transform.position.z); // Move the spawners vertical position to match the players vertical position
        }

        if (transform.position.y % 5 < 1) // Spawning occures after a gap of 5
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
            Instantiate(circle, transform.position, transform.rotation); // Spawn a circle
        } else // If spawnCount is odd
        {
            Instantiate(colorChanger, transform.position, transform.rotation); // Spawn a colorChanger
        }

        spawnCount++; // Increment spawnCount
    }
}
