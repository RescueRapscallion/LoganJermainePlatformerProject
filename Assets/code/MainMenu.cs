using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator MyAnimator;
    // Start is called before the first frame update
    public void Start()
    {
        Application.targetFrameRate = 120;


    }
    public void StartGame()
    {
        SceneManager.LoadScene(0);

    }
    public void EndGame()
    {
        SceneManager.LoadScene(4);

    }
    public void MainMen()
    {
        Application.Quit();

    }
    public void TriggerHowToPlay()
    {
        MyAnimator.SetTrigger("HowToPlay");
    }


}
