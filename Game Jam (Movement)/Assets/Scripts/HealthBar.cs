using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth = 100;

    public Texture2D bgImage;
    public Texture2D fgImage;
    //public GameObject HB;
    public float healthBarLength;
    //public Vector3 HPlength;
    // Use this for initialization
    void Start()
    {
        healthBarLength = Screen.width / 2;
       // HB = GameObject.Find("HP background");
       // HPlength = HB.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    public int damage = 0;
    // Update is called once per frame
    void Update()   
    {
        AddjustCurrentHealth(damage);
        float percentHP = curHealth / maxHealth;
        //HB.transform.localScale.x = HPlength * percentHP;
        damage = 0;
    }

    void OnGUI()
    {
        // Create one Group to contain both images
        // Adjust the first 2 coordinates to place it somewhere else on-screen
        GUI.BeginGroup(new Rect(0, 0, healthBarLength, 32));

        // Draw the background image
        GUI.Box(new Rect(0, 0, healthBarLength, 32), bgImage);

        // Create a second Group which will be clipped
        // We want to clip the image and not scale it, which is why we need the second Group
        GUI.BeginGroup(new Rect(0, 0, curHealth / maxHealth * healthBarLength, 32));

        // Draw the foreground image
        GUI.Box(new Rect(0, 0, healthBarLength, 32), fgImage);

        // End both Groups
        GUI.EndGroup();

        GUI.EndGroup();
    }

    public void AddjustCurrentHealth(int adj)
    {

        curHealth += adj;

        if (curHealth < 0)
            curHealth = 0;

        if (maxHealth < 1)
            maxHealth = 1;

        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
    }
}
