using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SumButtons : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameControler Controler;
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
    // Update is called once per frame
    private void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
