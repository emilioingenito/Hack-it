using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera_Movement : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D player;
    [SerializeField]
    public Rigidbody2D main_camera;

    
    // Start is called before the first frame update
   
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 t = new Vector2(4f+player.position.x, main_camera.position.y);
        main_camera.MovePosition(t);
    }
}
