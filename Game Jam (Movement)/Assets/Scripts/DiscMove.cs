using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscMove : MonoBehaviour
{
    public float speed = 20.0f;//default move speed
    private Rigidbody rb;//gets the regib body settings for movement
    private Vector2 screenBounds;//Gtes the size of the screen.

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector2(-speed, 0);//sets speed of disc to oposite of speed
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
        {
        if (transform.position.x < screenBounds.x-35|| transform.position.x > screenBounds.x + 50 || transform.position.y < screenBounds.y - 12 || transform.position.y > screenBounds.y + 2 )
        {
            Destroy(this.gameObject);//Destroys the disc if out of bounds
        }
    }
}
