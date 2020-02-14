using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Dictates the speed of the character.
    public float speed;

    //Dictates how high the player can jump.
    public float jumpforce;
    
    //To detect whether either of the arrow keys are pressed and  move accordingly.
    private float moveInput;
    
    //Name rigidbody2d as rb.
    private Rigidbody2D rb;

    //Declaring facingRight boolean as true.
    private bool facingRight = true;

    //Identifies if the character is standing on the ground.
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    //Declaring Jump Values.
    private int extraJumps;
    public int extraJumpValue;

    
   

    //New Function.
    //Start Function.
    private void Start()
    {
        //
        extraJumps = extraJumpValue;
        
        //To be able to tweak and use the characters rigidbody2d through the script.
        rb = GetComponent<Rigidbody2D>();
    }

    
    
    
    //New Function. 
    //FixedUpdate Function.
    private void FixedUpdate()
    {
        //
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);


        //Movement.
        moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        //Sprite Flipping.
        if(facingRight == false && moveInput > 0)
        {
            Flip();
        } else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }


    }



    //New Function.
    //Update Function.
    private void Update()
    {
        //
        if(isGrounded == true)
        {
            extraJumps = extraJumpValue;
        }



        //
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            Debug.Log("Jump");
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;
        } else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        {
            Debug.Log("Double Jump");
            rb.velocity = Vector2.up * jumpforce;
        }
    }






    //New Function.
    //Flip Function.
    void Flip()
    {
        //Scaler Calculations.
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }


}

