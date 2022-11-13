using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AIPat : MonoBehaviour
{
    // Start is called before the first frame update
    public float WalkSpeed;
    public bool mustPatrole;
    public Rigidbody2D Rb2d;
    void Start()
    {
        mustPatrole = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrole)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        Rb2d.velocity = new Vector2(WalkSpeed * Time.fixedDeltaTime, Rb2d.velocity.y);
    }
    void Flip()
    {
        mustPatrole = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        WalkSpeed = 1;
        mustPatrole = true;

    }

}




 
