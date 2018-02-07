using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	private Rigidbody rb;
	public int speed;
	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		
	}
}
