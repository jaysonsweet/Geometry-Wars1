using UnityEngine;
using System.Collections;

public class Triangle : Enemy {

	public Transform target;

	void Start () {
		target = GameObject.Find ("Ship").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 direction = (target.position - transform.position).normalized;
		rigidbody2D.velocity = (Vector2)direction * speed;
	}
}
