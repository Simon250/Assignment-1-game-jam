using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector2 screenBounds;//Finds screen size
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        speed = 6.0f;
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // tests if position is out of the top boundry
        if (transform.position.y > (screenBounds.y))
        {
            transform.position = transform.position - move;
        }
        // tests if position is out of the bottom boundry
        else if (transform.position.y < (-screenBounds.y))
        {
            transform.position = transform.position - move;
        }
        // tests if position is out of the right boundry (i think its right)
        else if (transform.position.x > (screenBounds.x))
        {
            transform.position = transform.position - move;
        }
        // tests if position is out of the left boundry
        else if (transform.position.x < (-screenBounds.x))
        {
            transform.position = transform.position - move;
        }
        else
        {
            transform.position += move * speed * Time.deltaTime;
        }
    }
}
