﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home_Screen : MonoBehaviour
{
    public void goToNextScreen()
    {
        SceneManager.LoadScene("02_Play");
    }
    public void exitApp()
    {
        Application.Quit();
    }
}
