using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Heart1;
    public Rigidbody2D Heart2;
    public Rigidbody2D Heart3;
    public Rigidbody2D Heart4;
    public Rigidbody2D Heart5;
    public Rigidbody2D Heart6;
    public Rigidbody2D Heart7;
    public Rigidbody2D Heart8;
    
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
       // if (PlayerBeh.Lifes == 2)
        {


          //  Heart1.gravityScale = -30;

        }
        if (PlayerBeh.Lifes == 0)
        {

            Heart2.gravityScale = 30;
        }
        if (PlayerBeh.Lifes == 3)
        {

            Heart4.gravityScale = 30;
        }
        if (PlayerBeh.Lifes == 4)
        {

            Heart5.gravityScale = 30;
        }
        if (PlayerBeh.Lifes == 5)
        {

            Heart6.gravityScale = 30;
        }
        if (PlayerBeh.Lifes == 6)
        {

            Heart7.gravityScale = 30;
        }
        if (PlayerBeh.Lifes == 7)
        {

            Heart8.gravityScale = 30;
        }
        if (PlayerBeh.Lifes == 8)
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("secret");
        }
          if (PlayerBeh.Lifes == 0)
        {

            Heart2.gravityScale = 30;
        }
    }
}
