using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void OnRestart()
    {
        Debug.Log("OnRestart called!");
        SceneManager.LoadScene("SampleScene");
    }

    public void OnQuit()
    {
        Debug.Log("OnQuit called!");
        Application.Quit();
    }
}
