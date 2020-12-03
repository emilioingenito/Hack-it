using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_coin : MonoBehaviour
{
    public int rotateSpeed;

    void Update()
    {
    	transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    
}
