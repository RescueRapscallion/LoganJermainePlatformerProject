using UnityEngine;

public class PlayerBeh : MonoBehaviour
{
    public float Speed = 10;
    public GameObject Blast;
    // public Vector3 BlastPos;
    public Vector2 Force = new Vector2(0, 50);
    public bool OnGround;
    Rigidbody2D rb2d;
    public int Lifes;
    public Vector2 JumpForce = new Vector2(0, 9000);
    private int diriction;
    public bool BeenHit = false;
    public bool Look = true;
    public AudioClip TapSound;
    public AudioClip CollisionSound;

   // float force = 10f;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Lifes = 2;
    }
 

    // Update is called once per frame
    public void Update()
    {
        // make it move 
        float move = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += move * Speed * Time.deltaTime;
        // pos.x = Mathf.Clamp(pos.x, -20.5f, 20.5f);
        transform.position = pos;
        bool shouldJump = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow));
       // if (shouldJump && !beenHit && OnGround)

       if(Lifes <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = (false);
            Lifes = 2;
            Invoke("ResetPlay", 1f);
            UnityEngine.SceneManagement.SceneManager.LoadScene(5);
        }
        {

          //  rb2d.velocity = Vector2.zero;
           //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
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
            diriction = -50;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            diriction = 50;

        }
        if (GetComponent<SpriteRenderer>().flipX == true)
        {
            // player facing left
            if (shouldJump && !BeenHit && OnGround)
            {

                rb2d.velocity = Vector2.zero;
                //rb2d.AddForce(JumpForce);
                rb2d.AddForce(new Vector2(JumpForce.x * diriction, JumpForce.y));


            }

        }
        else
        {
            //player facing right
            if (shouldJump && !BeenHit && OnGround)
            {
                print(diriction);
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2 (JumpForce.x * diriction, JumpForce.y ));
                // rb2d.AddForce(transform.right*JumpForce);
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
        else if (collision.gameObject.transform.tag == "enemey")
        {
            --Lifes;
            {
                print(Lifes);
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(JumpForce.x * diriction, JumpForce.y));
                // rb2d.AddForce(transform.right*JumpForce);
            }
        }
        else if (collision.gameObject.transform.tag == "rot")
        {
            ++Lifes;
            {
                print(Lifes);
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(JumpForce.x * diriction, JumpForce.y));
                // rb2d.AddForce(transform.right*JumpForce);
            }
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
    private void ResetPLay()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        transform.position = new Vector3(-1.088f, -0.773f, 0);
    }


}