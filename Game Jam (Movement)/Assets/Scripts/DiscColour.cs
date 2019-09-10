using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscColour : MonoBehaviour
{
    Color[] DC = { Color.white, Color.yellow, Color.green, Color.red, Color.blue, Color.black };

    // Start is called before the first frame update
    void Start()
    {
        int rng = Random.Range(0, 5);
        gameObject.GetComponent<Renderer>().material.color = DC[rng];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
