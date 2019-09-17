using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GotoMainScene()//Main game switcher
    {
        Debug.Log("Started");
        SceneManager.LoadScene("PlayerMoveTest");//Loads game scene
    }
    public void GotoMainMenu()//Main Menu switcher
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("Main Menu GUI");//Loads Main Menu Scene
    }
    public void GotoControlMenu()//Control menu switcher
    {
        Debug.Log("Control Menu");
        SceneManager.LoadScene("MMControls");//Loads Control Scene
    }


}
