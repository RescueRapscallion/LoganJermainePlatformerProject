using UnityEngine;

public class PlayerBeh : MonoBehaviour
{
    public float speed = 10;
    public GameObject Blast;
    // public Vector3 BlastPos;
    public Vector2 Force = new Vector2(0, 20);
    public bool OnGround;
    Rigidbody2D rb2d;
    public Vector2 jumpForce = new Vector2(0, 300);

    public bool beenHit = false;

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
        pos.x += move * speed * Time.deltaTime;
       // pos.x = Mathf.Clamp(pos.x, -20.5f, 20.5f);
        transform.position = pos;
        bool shouldJump = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow));
        if (shouldJump && !beenHit && OnGround)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(jumpForce);

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