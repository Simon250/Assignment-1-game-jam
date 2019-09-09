using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscMove : MonoBehaviour
{
    public float speed = 10.0f;//default move speed
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);//sets speed of disc to oposite of speed (eg -10)
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        if (transform.position.x < screenBounds.x*-2)
        {
            Destroy(this.gameObject);
        }
    }
}
