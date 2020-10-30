using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D player;

    private void FixedUpdate()
    {
        player.velocity = new Vector2(2f,0f);
    }


}
