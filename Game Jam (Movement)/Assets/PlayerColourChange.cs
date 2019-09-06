using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColourChange : MonoBehaviour
{
    Color[] colours = {Color.white, Color.yellow, Color.green, Color.red, Color.blue, Color.black};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)) {

            Color temp = GetComponent<SpriteRenderer>().material.color;
            int cc = 0;

            if (colours[0] == temp)
            {
                gameObject.GetComponent<Renderer>().material.color = colours[5];
            }
            else
            {
                do
                {

                    if (colours[cc] == temp)
                    {
                        gameObject.GetComponent<Renderer>().material.color = colours[cc - 1];
                        cc = 6;
                    }
                    else
                    {
                        cc++;
                    }

                } while (cc <= 5);
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            Color temp = GetComponent<SpriteRenderer>().material.color;
            int cc = 0;

            if (colours[5] == temp)
            {
                gameObject.GetComponent<Renderer>().material.color = colours[0];
            }
            else
            {
                do
                {

                    if (colours[cc] == temp)
                    {
                        gameObject.GetComponent<Renderer>().material.color = colours[cc + 1];
                        cc = 6;
                    }
                    else
                    {
                        cc++;
                    }

                } while (cc <= 5);
            }
        }
    }
}
