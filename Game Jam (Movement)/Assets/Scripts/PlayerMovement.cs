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
        //var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //// tests if position is out of the top boundry
        //if (transform.position.y > (screenBounds.y))
        //{
        //    transform.position = transform.position - move;
        //}
        //// tests if position is out of the bottom boundry
        //else if (transform.position.y < (-screenBounds.y))
        //{
        //    transform.position = transform.position - move;
        //}
        //// tests if position is out of the right boundry (i think its right)
        //else if (transform.position.x > (screenBounds.x))
        //{
        //    transform.position = transform.position - move;
        //}
        //// tests if position is out of the left boundry
        //else if (transform.position.x < (-screenBounds.x))
        //{
        //    transform.position = transform.position - move;
        //}
        //else
        //{
        //    transform.position += move * speed * Time.deltaTime;
        //}
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Get new position in advance
        float xPos = transform.position.x + movement.x * speed * Time.fixedDeltaTime;
        float yPos = transform.position.y + movement.y * speed * Time.fixedDeltaTime;
        float x_max = screenBounds.x - 0.55f;
        float y_max = screenBounds.y - 0.55f;
        float x_min = -screenBounds.x + 0.55f;
        float y_min = -screenBounds.y + 0.55f;

        // Check if new position goes over boundaries and if true clamp it
        if (xPos > x_max || xPos < x_min)
        {
            if (xPos > x_max)
                transform.position = new Vector3(x_max, transform.position.y);
            else
                transform.position = new Vector3(x_min, transform.position.y);
            movement.x = 0;
        }
        if (yPos > y_max || yPos < y_min)
        {
            if (yPos > y_max)
                transform.position = new Vector3(transform.position.x, y_max);
            else
                transform.position = new Vector3(transform.position.x, y_min);
            movement.y = 0;
        }

        transform.position += movement * speed * Time.deltaTime;
    }
}
