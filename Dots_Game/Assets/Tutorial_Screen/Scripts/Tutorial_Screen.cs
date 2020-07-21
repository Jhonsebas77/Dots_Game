using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_Screen : MonoBehaviour
{
    public GameObject Step_01;
    public GameObject Step_02;
    public GameObject Step_03;
      void Start()
    {
        Step_01.SetActive(true);
        Step_02.SetActive(false);
        Step_03.SetActive(false);
    }
    public void goToBackScreen()
    {
        SceneManager.LoadScene("02_Play");
    }
    public void goToStep01ToStep02()
    {
        Step_01.SetActive(false);
        Step_02.SetActive(true);
        Step_03.SetActive(false);
    }
    public void goToStep02ToStep03()
    {
        Step_01.SetActive(false);
        Step_02.SetActive(false);
        Step_03.SetActive(true);
    }
}
