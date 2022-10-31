using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class testrang2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Vector2 TossForce;
    public float moveSpeed;
    Rigidbody2D rb2d;
    private int diriction;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempVector2 = Vector2.MoveTowards(transform
            .position, Player.transform.position, moveSpeed * Time.deltaTime);
       
        transform.position = new Vector3(tempVector2.x, tempVector2.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // player facing left
            if (Input.GetKeyDown(KeyCode.Z))
            {

                rb2d.velocity = Vector2.zero;
                //rb2d.AddForce(JumpForce);
                rb2d.AddForce(new Vector2(TossForce.x * diriction, TossForce.y));


            }

        }
        else
        {
            //player facing right
            if (Input.GetKeyDown(KeyCode.Z))
            {
               
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(TossForce.x * diriction, TossForce.y));
                // rb2d.AddForce(transform.right*JumpForce);
            }
        }

    }

}
