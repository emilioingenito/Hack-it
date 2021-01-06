using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{ 
    public GameObject me;
    public AudioSource collectSound;
    public int coinValue=1;

    void OnTriggerEnter2D(Collider2D other)
    {
       
            collectSound.Play();
            Destroy(me.gameObject);
            ScoreManager.instance.ChangeScore(coinValue);
        
    }

}
