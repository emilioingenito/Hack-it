using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comportamento_Bottoni : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
