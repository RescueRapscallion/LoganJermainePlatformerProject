using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //vo/i//d Update()
    ///
      private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        //  {/
        //   / UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }//
    }

