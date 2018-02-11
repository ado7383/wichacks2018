using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    public Vector3 offset;
    public Vector2 Minimum;
    public Vector2 Maximum;

    void FixedUpdate()
    {
        if (!(player.transform.position.x <= Minimum.x) && !(player.transform.position.x >= Maximum.x))
        {
            transform.position = new Vector3(player.transform.position.x + offset.x, offset.y, offset.z);
        }
    }
}
