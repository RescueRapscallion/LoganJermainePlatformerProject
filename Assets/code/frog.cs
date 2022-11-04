using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Frog;
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Frog"))
        {
            Application.Quit();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
