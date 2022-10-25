using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour

{
    //REFERENCE TO THE PLAYER
    bool returning = false;
    private int diriction;
    public Vector3 boomForce;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        //add horizontal force here
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(boomForce);
        
        
        //INVOKE changeMode
    }

    // Update is called once per frame
    void Update()
    {
        //Goback()
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            GetComponent<SpriteRenderer>().flipX = true;
            diriction = -50;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            diriction = 50;

        }
        if (GetComponent<SpriteRenderer>().flipX == true)
        {
            // player facing left
            if (Input.GetKeyDown(KeyCode.Z));
            {

                rb2d.velocity = Vector2.zero;
                //rb2d.AddForce(JumpForce);
                rb2d.AddForce(new Vector2(boomForce.x * diriction, boomForce.y));


            }

        }
        else
        {
            //player facing right
            
            {
                print(diriction);
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(boomForce.x * diriction, boomForce.y));
                // rb2d.AddForce(transform.right*JumpForce);
            }
        }
    }

    private void GoBack()
    {
        //if returning
            //vector3 . movetowards player 
    }

    private void ChangeMode()
    {
        returning = true;
    }
}
