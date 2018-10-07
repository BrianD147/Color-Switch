using UnityEngine;

public class Despawner : MonoBehaviour {

    new public Transform camera;
    float zAxis;
    float yAxis;

    void Update()
    {
        zAxis = camera.position.z + 10;
        yAxis = camera.position.y - 10;
        transform.position = new Vector3(camera.position.x, yAxis, zAxis);
    }

    void OnTriggerEnter2D(Collider2D col) // When a collision occurs
    {
        if (col.tag != "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
