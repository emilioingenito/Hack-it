using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathByFalling : MonoBehaviour
{
    public int fallBoundary = 150;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= fallBoundary)
        {
            SceneManager.LoadScene("Death Scene");
        }
    }
}
