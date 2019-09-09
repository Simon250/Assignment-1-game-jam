using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that defines the Move speed of the Discs
public class Disc : MonoBehaviour {
	public float speed = 10.0f;//default move speed
	private Rigidbody2D rb;

    void Start(){
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-speed, 0);//sets speed of disc to oposite of speed (eg -10)
    }

    void Update() {
        
    }
}
