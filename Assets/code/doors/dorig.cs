using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dorig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("1");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
