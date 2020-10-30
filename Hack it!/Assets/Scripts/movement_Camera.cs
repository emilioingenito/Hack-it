using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_Camera : MonoBehaviour
{
    public Rigidbody2D camera;
    private void FixedUpdate()
    {
        camera.velocity = new Vector2(2f, 0f);
    }

}
