using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColourChange : MonoBehaviour
{
    Color[] colours = {Color.white, Color.yellow, Color.green, Color.red, Color.blue, Color.black};
    public Sprite WPI;
    public Sprite YPI;
    public Sprite GPI;
    public Sprite RPI;
    public Sprite BluPI;
    public Sprite BlaPI;

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

            if (colours[0] == temp)//stops errors and loops the array
            {
                gameObject.GetComponent<Renderer>().material.color = colours[5];
                gameObject.GetComponent<SpriteRenderer>().sprite = BlaPI;
            }
            else
            {
                do
                {

                    if (colours[cc] == temp)
                    {
                        gameObject.GetComponent<Renderer>().material.color = colours[cc - 1];//sets colour for collition detection

                        //sets sprite based on colour
                        if (cc == 1)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = WPI;
                        }
                        else if (cc == 2)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = YPI;
                        }
                        else if (cc == 3)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = GPI;
                        }
                        else if (cc == 4)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = RPI;
                        }
                        else if (cc == 5)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = BluPI;
                        }
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

            if (colours[5] == temp)//stops errors and loops the array
            {
                gameObject.GetComponent<Renderer>().material.color = colours[0];
                gameObject.GetComponent<SpriteRenderer>().sprite = WPI;
            }
            else
            {
                do
                {

                    if (colours[cc] == temp)
                    {
                        gameObject.GetComponent<Renderer>().material.color = colours[cc + 1];//sets colour for collition detection

                        //sets sprite based on colour
                        if (cc == 0)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = YPI;
                        }
                        else if (cc == 1)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = GPI;
                        }
                        else if (cc == 2)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = RPI;
                        }
                        else if (cc == 3)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = BluPI;
                        }
                        else if (cc == 4)
                        {
                            gameObject.GetComponent<SpriteRenderer>().sprite = BlaPI;
                        }
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
