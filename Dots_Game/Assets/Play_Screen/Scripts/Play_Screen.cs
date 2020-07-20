using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Screen : MonoBehaviour
{
    public void goToBackScreen()
    {
        SceneManager.LoadScene("01_Home");
    }
    public void goToPlayTutorial()
    {
        SceneManager.LoadScene("03_Tutorial");
    }
    public void goToPlayEasy()
    {
        SceneManager.LoadScene("04_Easy");
    }
    public void goToPlayHard()
    {
        SceneManager.LoadScene("05_Hard");
    }
}
