using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform player; // the players location

	void Update () {
		if(player.position.y > transform.position.y) // If the players vertical position gets bigger than the cameras vertical position
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z); // Move the cameras vertical position to match the players
        }
	}
}
