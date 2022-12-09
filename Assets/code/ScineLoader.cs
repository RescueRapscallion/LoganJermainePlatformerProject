using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScineLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public int SceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
          LoadScene();

        }
    }

}
