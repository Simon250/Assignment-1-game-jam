using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private void Start()
    {
        
    }

    private void Update()
    {

    }
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        GameObject Player = GameObject.Find("Player");
        GameObject scoretext = GameObject.Find("Score");
        GameObject ui = GameObject.Find("Main Camera");

        //Check for a match with the specified name on any GameObject that collides with the player
        if (collision.gameObject.GetComponent<Renderer>().material.color == Player.gameObject.GetComponent<Renderer>().material.color) {
            string texttemp = scoretext.GetComponent<TextMesh>().text;
            string[] splitArray = texttemp.Split(char.Parse(" "));
            string temp2 = splitArray[0];
            string temp = splitArray[1];
            int tempnum = int.Parse(temp);
            tempnum += 100;
            temp2 = temp2 + " " + tempnum;
            
            scoretext.GetComponent<TextMesh>().text = temp2;
        }
        else {
            ui.GetComponent<HealthBar>().damage = -20;
            Debug.Log(ui.GetComponent<HealthBar>().damage);
        }
        Player = null;
        scoretext = null;

    }
}
