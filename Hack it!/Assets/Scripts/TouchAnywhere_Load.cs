using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchAnywhere_Load : MonoBehaviour
{
	public string scene_name;

 	void Update()
 	{
  		if (Input.GetMouseButtonDown(0))
  	 	{
    		SceneManager.LoadScene(scene_name);
		}

   	}
}

