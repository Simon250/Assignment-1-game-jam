using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBar : MonoBehaviour
{
    public int nextlevel = 100;
    public int curPoints = 0;

    public Texture2D bgImage;
    public Texture2D fgImage;

    public float scoreBarLength;

    // Use this for initialization
    void Start()
    {
        scoreBarLength = Screen.width / 2;
    }

    public int points = 0;
    // Update is called once per frame
    void Update()
    {
        AddjustCurrentHealth(points);
        points = 0;
    }

    void OnGUI()
    {
        // Create one Group to contain both images
        // Adjust the first 2 coordinates to place it somewhere else on-screen
        GUI.BeginGroup(new Rect(Screen.width/2, 32, scoreBarLength, 32));

        // Draw the background image
        GUI.Box(new Rect(Screen.width / 2, 32, scoreBarLength, 32), bgImage);

        // Create a second Group which will be clipped
        // We want to clip the image and not scale it, which is why we need the second Group
        GUI.BeginGroup(new Rect(Screen.width/2, 32, curPoints / nextlevel * scoreBarLength, 32));

        // Draw the foreground image
        GUI.Box(new Rect(Screen.width / 2, 32, scoreBarLength, 32), fgImage);

        // End both Groups
        GUI.EndGroup();

        GUI.EndGroup();
    }

    public void AddjustCurrentHealth(int adj)
    {

        curPoints += adj;

        if (curPoints < 0)
            curPoints = 0;

        scoreBarLength = (Screen.width / 2) * (curPoints / (float)nextlevel);
    }
}
