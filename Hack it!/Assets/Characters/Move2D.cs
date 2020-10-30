using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    Animator animator; //this will be used to switch between animations
    Rigidbody2D rb2d; //to reference to the rigid body
    SpriteRenderer spriteRenderer;//we'll use this to flip the character as we turn left and right

    bool isGrounded;
    [SerializeField] //this makes the ground check a field in the character inspector
    Transform groundCheck;

    private float runspeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    
    /*Similar to the Update function but more accurate for games based in the physic world*/
    private void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKey("right")) //se l'input è il tasto freccetta destra
        {
            rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y); //we're giving a new velocity that's 2 on the x and keeping the y
            if (isGrounded)
                animator.Play("Run"); //if the player is going right we want him to play the animation Run
            spriteRenderer.flipX = false; //we dont want it to flip when he goes right
        }
        else if (Input.GetKey("left")) //se l'input è il tasto freccetta sinistra
        {
            rb2d.velocity = new Vector2(-runspeed, rb2d.velocity.y);
            if (isGrounded)
                animator.Play("Run");
            spriteRenderer.flipX = true; //we want him to flip when he goes left
        }
        else if (Input.GetKey("down"))
        {
            rb2d.velocity = new Vector2(0, 0);
            animator.Play("Colpo");
        }
        else if (isGrounded)
        {
            animator.Play("Player");
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        if ((Input.GetKey("space") || Input.GetKey("up")) && isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5); //we'll keep the movement but we'll change the y 
            animator.Play("Jump");
        }
    }
}
