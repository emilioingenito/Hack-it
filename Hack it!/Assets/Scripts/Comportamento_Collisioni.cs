using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comportamento_Collisioni : MonoBehaviour
{
   
    public IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Animator animator = player.GetComponent<Animator>();

        if (collision.gameObject.Equals(player))
        {
           // animator.Play("Death");
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("01 collision");
        }
    }
}
