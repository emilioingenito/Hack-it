using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class uccisione_bug : MonoBehaviour
{
    public Rigidbody2D bug;
    public Rigidbody2D me;
    public GameObject bugOgg;
    public GameObject player;
    bool ucciso = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.Equals(player))
        {
            Destroy(bugOgg);
            ucciso = true;
        }
              
    }

    void FixedUpdate()
    {
        if(ucciso==false)
        me.MovePosition(bug.position);
    }
}
