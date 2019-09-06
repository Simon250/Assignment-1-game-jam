using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position += move * speed * Time.deltaTime;
    }
}
