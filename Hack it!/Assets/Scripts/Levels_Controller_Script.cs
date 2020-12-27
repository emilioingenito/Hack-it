using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels_Controller_Script : MonoBehaviour
{
    public Button level02, level03;
    int levelPassed;

    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("levelPassed");
        level02.interactable = false;
        level03.interactable = false;

        switch(levelPassed)
        {
            case 1:
                level02.interactable = true;
                break;

            case 2:
                level02.interactable = true;
                level03.interactable = true;
                break;
        }

    }

    public void ResetLevelPref()
    {
        level02.interactable = false;
        level03.interactable = false;
        PlayerPrefs.DeleteAll();
    }


}
