using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chace : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject Player;
    public Vector2 TossForcs = new Vector2(0, 9000);
    public float MoveSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempVector2 = Vector2.MoveTowards(transform.position, Player.transform.position, MoveSpeed * Time.deltaTime);

        transform.position = new Vector3(tempVector2.x, tempVector2.y, transform.position.z);

    }
}
