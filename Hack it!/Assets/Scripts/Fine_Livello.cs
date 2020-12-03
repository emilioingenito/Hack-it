using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fine_Livello : MonoBehaviour
{
    GameObject player;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (collision.gameObject.Equals(player))
        {
            //qui verrà messo il controllo sul numero minimo di oggetti raccolti
            //if(HorizontalWrapMode raccolto tutti gli elementi)
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //else
            SceneManager.LoadScene("Fine_livello_successo");

        }
    }
}
