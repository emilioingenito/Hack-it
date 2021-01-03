using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento_collectable : MonoBehaviour
{
    public GameObject me;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        


        if (collision.gameObject.Equals(player))
        {
            GameObject.Destroy(me);
        }
    }
}
