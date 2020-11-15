using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Livello_01");
    }
    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
