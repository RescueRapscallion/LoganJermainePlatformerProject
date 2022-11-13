using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem2 : MonoBehaviour
    // got this code from a yt might impliment later fully. not a huge fan of just 1 enemy types.
{
    // Start is called before the first frame update
    public float Hp;
    public float Mxhp;
    void Start()
    {
        Hp = Mxhp;
    }
    
    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hp -= damage;
       // if (Hp <= 0 >)
        {
            Destroy(gameObject);
        }
    }
   
}







































