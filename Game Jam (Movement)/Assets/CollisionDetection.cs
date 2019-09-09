using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        GameObject colidedobject = GameObject.Find(collision.gameObject.name);
        GameObject Player = GameObject.Find("Player");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (colidedobject.GetComponent<Renderer>().material.color == Player.gameObject.GetComponent<Renderer>().material.color)
        {


        }
        if(colidedobject.GetComponent<Renderer>().material.color != Player.gameObject.GetComponent<Renderer>().material.color)
        {
            GameObject ui = GameObject.Find("Main Camera");
            ui.GetComponent<HealthBar>().damage = -20;
        }
    }
}
