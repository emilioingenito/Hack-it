using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug_Mov : MonoBehaviour
{
    public GameObject bug;
	public Transform pos1, pos2;
	public float speed;
	public Transform startPos;

	Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == pos1.position)
        {
        	nextPos = pos2.position;
            bug.transform.localScale = new Vector3(6, 6, 0);
        }

        if(transform.position == pos2.position)
        {
        	nextPos = pos1.position;
            bug.transform.localScale = new Vector3(-6, 6, 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime);

    }



}
