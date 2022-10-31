using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemey;
    public int Ballin;

    void Start()
    {
        {
            InvokeRepeating("CreateEnemey", 2.5f, .5f);

        }
    }
    public void CreateEnemey()
    {
        float randomy = Random.Range(-5f, 5f);
        Instantiate(Enemey, new Vector2(25, randomy), Quaternion.identity);
        Ballin++;
        if (Ballin > 15)
        {
            CancelInvoke("CreateEnemey");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
