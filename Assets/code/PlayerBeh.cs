using UnityEngine;

public class PlayerBeh : MonoBehaviour
{
    public float Speed = 10;
    public GameObject Blast;
    // public Vector3 BlastPos;
    public Vector2 Force = new Vector2(0, 50);
    public bool OnGround;
    Rigidbody2D rb2d;
    public Vector2 JumpForce = new Vector2(0, 5000);
    
    public bool beenHit = false;
    public bool Look = true;
    public AudioClip TapSound;
    public AudioClip CollisionSound;

   // float force = 10f;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        // make it move 
        float move = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += move * Speed * Time.deltaTime;
        // pos.x = Mathf.Clamp(pos.x, -20.5f, 20.5f);
        transform.position = pos;
        bool shouldJump = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow));
       // if (shouldJump && !beenHit && OnGround)
        {

          //  rb2d.velocity = Vector2.zero;
           // rb2d.AddForce(JumpForce);

        }
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            //   rb2d.AddForce(Vector2.up * force, (ForceMode2D)ForceMode.Impulse);
        }
        //BlastPos = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);

        {

        }
        // if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate(Blast, BlastPos, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }
        if (GetComponent<SpriteRenderer>().flipX == true)
        {
            // player facing left
            if (shouldJump && !beenHit && OnGround)
            {

                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(JumpForce);

            }

        }
        else
        {
            //player facing right
            if (shouldJump && !beenHit && OnGround)
            {

                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(JumpForce );
                rb2d.AddForce(transform.right*JumpForce);
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "wall")
        {
            Debug.Log("I hit " + collision.gameObject.name);

        }
        else if (collision.gameObject.transform.tag == "Ground")
        {
            OnGround = true;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
       if (collision.gameObject.transform.tag == "Ground")
        {
            Debug.Log("Grounded " + collision.gameObject.name);
       
            OnGround = false;
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        
    }
}