using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comportamento_Collisioni_Bug : MonoBehaviour
{
   
    public GameObject palyer;
    public Rigidbody2D bug;
  
       

    // Start is called before the first frame update
   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D.Destroy(gameObject,0.5f);
    }*/
   
    private IEnumerator OnCollisionEnter2D(Collision2D collision)
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
