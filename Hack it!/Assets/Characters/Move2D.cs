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
    [SerializeField] 
    Transform groundCheckL;
    [SerializeField]
    Transform groundCheckR;

    [SerializeField]
    private float runspeed = 3;
    [SerializeField]
    private float jumpspeed = 5;

    [SerializeField]
    private FixedJoystick joystick;

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
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"))||
            Physics2D.Linecast(transform.position, groundCheckL.position, 1 << LayerMask.NameToLayer("Ground")) ||
            Physics2D.Linecast(transform.position, groundCheckR.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (joystick.Horizontal >= .4f) //se l'input è il tasto freccetta destra
        {
            rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y); //we're giving a new velocity that's 2 on the x and keeping the y
            if (isGrounded)
                animator.Play("Run"); //if the player is going right we want him to play the animation Run
            spriteRenderer.flipX = false; //we dont want it to flip when he goes right
        }
        else if (joystick.Horizontal <= -.4f) //se l'input è il tasto freccetta sinistra
        {
            rb2d.velocity = new Vector2(-runspeed, rb2d.velocity.y);
           if (isGrounded)
                animator.Play("Run");
            spriteRenderer.flipX = true; //we want him to flip when he goes left
            
        }
        else if (rb2d.velocity.x == 0 && rb2d.velocity.y == 0)
        {
            animator.Play("Player");
        }
    }

    public void jump()
    {
        if (isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpspeed); //we'll keep the movement but we'll change the y 
            animator.Play("Jump");
        /*  if (Input.GetKey("down"))
            {
                //rb2d.velocity = new Vector2(0, rb2d.velocity.y);
                //animator.Play("Colpo");
            }
           */
        }
    }
}
