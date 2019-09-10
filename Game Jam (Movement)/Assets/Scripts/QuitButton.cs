using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    private Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(QuitGame);
    }
    private void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}