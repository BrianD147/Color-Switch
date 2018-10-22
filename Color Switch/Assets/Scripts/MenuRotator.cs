using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotator : MonoBehaviour {

    public float speed; // Speed at which the circle will rotate

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime); // Rotate the circle about the z-axis
    }
}
