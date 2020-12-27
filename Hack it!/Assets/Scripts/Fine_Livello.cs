using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fine_Livello : MonoBehaviour
{
    GameObject player;
    int levelPassed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (collision.gameObject.Equals(player))
        {
            //qui verrà messo il controllo sul numero minimo di oggetti raccolti
            //if(HorizontalWrapMode raccolto tutti gli elementi)
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //else
            levelPassed = PlayerPrefs.GetInt("levelPassed");
            PlayerPrefs.SetInt("levelPassed", levelPassed + 1);
            SceneManager.LoadScene("Fine_livello_successo");

        }
    }
}
