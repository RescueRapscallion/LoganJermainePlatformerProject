using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Heart1;
    public Rigidbody2D Heart2;
    public PlayerBeh PlayerBeh;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerBeh.Lifes == 1)
        {
        
       
            Heart1.gravityScale = 30;
            
        }
        if (PlayerBeh.Lifes == 2)
        {


            Heart1.gravityScale = -30;

        }
        if (PlayerBeh.Lifes == 0)
        {

            Heart2.gravityScale = 30;
        }
    }
}
