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

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x == pos1.position.x)
        {
        	nextPos = pos2.position;
            spriteRenderer.flipX = true;
            // bug.transform.localScale = new Vector3(6, 6, 0);
        }

        if(transform.position.x == pos2.position.x)
        {
        	nextPos = pos1.position;
            spriteRenderer.flipX = false;
            // bug.transform.localScale = new Vector3(-6, 6, 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime);

    }



}
