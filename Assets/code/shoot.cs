using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shoot : MonoBehaviour

{
    //REFERENCE TO THE PLAYER
    bool returning = false;
    public bool HasBeenThrown;
    bool r;
    public GameObject Player;
    public int moveSpeed;
    int diriction;
    public Vector3 boomForce;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        //add horizontal force here
       rb2d = GetComponent<Rigidbody2D>();
        
        
        //INVOKE changeMode
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HasBeenThrown = false;
        }
    }
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
          
        }
        if (HasBeenThrown == false)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                rb2d.AddForce(boomForce,ForceMode2D.Impulse);
               
            }
            if (Input.GetKeyUp(KeyCode.Z))
            {
                HasBeenThrown = true;

            }

        }
        else
        {
            if (Input.GetKey(KeyCode.Z))
            {
                rb2d.velocity = Vector3.zero;
                transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);

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
