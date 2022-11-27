using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour
{
    // Start is called before the first frame update
    public static int SceneNumber;
    void Start()
    {
        if (SceneNumber == 0)
        {
            StartCoroutine(ToSplashTwo ());
        }
        if (SceneNumber == 1)
        {
            StartCoroutine(ToMainMenu());
        }
    }
    IEnumerator ToSplashTwo ()
    {
        yield return new WaitForSeconds(2);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    
    
        IEnumerator ToMainMenu()
        {
            yield return new WaitForSeconds(15);
            SceneNumber = 2;
            SceneManager.LoadScene(2);
        }
    
}































