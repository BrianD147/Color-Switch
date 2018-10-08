using UnityEngine;

public class Despawner : MonoBehaviour {

    new public Transform camera; // Camera transform
    float zAxis; // Distance along the z axis
    float yAxis; // Distance along the y axis (vertical)

    void Update()
    {
        zAxis = camera.position.z + 10; // Set the z axis to the current camera z position + 10
        yAxis = camera.position.y - 10; // Set the y axis to the current camera y position - 10
        transform.position = new Vector3(camera.position.x, yAxis, zAxis); // Position the despawner transform to the new co-ordinates
    }

    void OnTriggerEnter2D(Collider2D col) // When a collision occurs
    {
        if (col.tag != "Player") // If the collision is with anything other than the player
        {
            Destroy(col.gameObject); // Destory the gameobject
        }
    }
}
