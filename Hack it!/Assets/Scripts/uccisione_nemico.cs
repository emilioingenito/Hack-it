using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class uccisione_nemico : MonoBehaviour
{
    public Rigidbody2D nemico;
    public Rigidbody2D me;
    public GameObject ogg;
    bool ucciso = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");  //in questo modo associo il giocatore in ogni livello a player
        if (collision.gameObject.Equals(player))
        {
            Destroy(ogg);  //mi serve un gameObject e non un RigidBody2D
            ucciso = true;
        }
              
    }

    void FixedUpdate()
    {
        if(ucciso==false)
        me.MovePosition(nemico.position);
    }
}
