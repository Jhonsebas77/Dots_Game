using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_Home_Screen : MonoBehaviour
{
    public void goToNextScreen()
    {
        SceneManager.LoadScene("Play");
    }
}
