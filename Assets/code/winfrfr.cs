using UnityEngine;

public class winfrfr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("winfrfr");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
