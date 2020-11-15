using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm = new GameMaster();

    [SerializeField]
    private GameObject GameOverUI;

    private static int remainingLives = 1;
    public static int RemainingLives
    {
        get { return remainingLives; }
    }

   public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    public static void KillPlayer (Player player)
    {
        Destroy(player.gameObject);
        remainingLives--;
        if(remainingLives<=0)
        {
            gm.EndGame();
        }
    }
}
