using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GotoMainScene()
    {
        Debug.Log("Loaded Game");
        SceneManager.LoadScene("PlayerMoveTest");
    }
    public void GotoMainMenu()
    {
        Debug.Log("Loaded Main Menu");
        SceneManager.LoadScene("Main Menu GUI");
    }
    public void GotoControls()
    {
        Debug.Log("Loaded Controls");
        SceneManager.LoadScene("ControlsMM");
    }
}
