using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscColour : MonoBehaviour
{
    Color[] DC = { Color.white, Color.yellow, Color.green, Color.red, Color.blue, Color.black };
    public Sprite WDI;
    public Sprite YDI;
    public Sprite GDI;
    public Sprite RDI;
    public Sprite BluDI;
    public Sprite BlaDI;

    // Start is called before the first frame update
    void Start()
    {
        int rng = Random.Range(0, 6);
        gameObject.GetComponent<Renderer>().material.color = DC[rng];//sets colour for collition detection

        //sets sprite based on spawn colour
        if (rng == 0) {
            gameObject.GetComponent<SpriteRenderer>().sprite = WDI;
        }
        else if (rng == 1) {
            gameObject.GetComponent<SpriteRenderer>().sprite = YDI;
        }
        else if (rng == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = GDI;
        }
        else if (rng == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = RDI;
        }
        else if (rng == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BluDI;
        }
        else if (rng == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BlaDI;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
