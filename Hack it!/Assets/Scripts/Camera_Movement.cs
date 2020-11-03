using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D player;
    [SerializeField]
    public Rigidbody2D main_camera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        main_camera.MovePosition(player.position);
    }
}
