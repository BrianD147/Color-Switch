using UnityEngine;

public class Rotator : MonoBehaviour {

    [SerializeField]
    private float speed; // Speed at which the circle will rotate

	void Update () {
        transform.Rotate(0f, 0f, speed * Time.deltaTime); // Rotate the circle about the z-axis
	}
}
