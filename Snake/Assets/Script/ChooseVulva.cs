using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseVulva : MonoBehaviour
{
    public void SelectVulvaOne ()
    {
       DataController.SetVulvaType(1, true);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectVulvaTwo ()
    {
       DataController.SetVulvaType(2, true);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectVulvaThree ()
    {
       DataController.SetVulvaType(3, true);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

