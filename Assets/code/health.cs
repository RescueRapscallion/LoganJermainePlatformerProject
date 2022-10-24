using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D heart1;
    public Rigidbody2D heart2;
    public PlayerBeh playerBeh;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerBeh.Lifes == 1)
        {
        
       
            heart1.gravityScale = 30;
            
        }
        if (playerBeh.Lifes == 0)
        {

            heart2.gravityScale = 30;
        }
    }
}
