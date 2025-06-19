using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    Vector3 OFFSET_ = new Vector3(0, 5, -7);
    void Update()
    {
        transform.position = player.transform.position + OFFSET_;

        transform.rotation = Quaternion.Euler(0, player.transform.eulerAngles.y, 0);
        // Ensure the camera always looks at the player
    }
}
