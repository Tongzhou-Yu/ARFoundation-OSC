using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("iOS_0_Intro");
    }

    public void Door()
    {
        SceneManager.LoadScene("iOS_1_Augmented Virtuality");
    }

    public void AR()
    {
        SceneManager.LoadScene("iOS_2_Augmented Reality");
    }
}
