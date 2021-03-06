﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Comportamento_Collisioni_Nemico : MonoBehaviour
{

    

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Animator animator = player.GetComponent<Animator>();

        if (collision.gameObject.Equals(player))
        {
            FindObjectOfType<AudioManager>().Play("Death");
             animator.Play("Death");
            yield return new WaitForSeconds(0.5f);
                SceneManager.LoadScene("Death Scene");
        }
    }
}
