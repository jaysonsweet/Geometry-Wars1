using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	/* Declaration of a public variable of float type called 
	   acceleration. We will use this to accelerate the script. */
	public float acceleration;
	public float drag;
	public float maxSpeed;

	private Vector2 velocity;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			velocity.x += Time.fixedDeltaTime * acceleration;
				
		} 

		else if (Input.GetKey (KeyCode.A)) {
			velocity.x -= Time.fixedDeltaTime * acceleration;
		}			
		
		          
		else if ( velocity.x != 0 ) {
			int value = velocity.x > 0 ? -1 : 1;
			velocity.x += Time.fixedDeltaTime * value * drag;

			if ( Mathf.Abs( velocity.x ) < 1 ) {
				velocity.x = 0;
			}
		}
		/*if the ship is moving right Then slow down to the left. otherwise if the ship moving left. Then slow down to the right.*/


		if (Input.GetKey( KeyCode.W )) {
			velocity.y += Time.fixedDeltaTime * acceleration;
		}

		else if (Input.GetKey( KeyCode.S )) {
			velocity.y -= Time.fixedDeltaTime * acceleration;
		}

		else if ( velocity.y != 0 ) {
			int value = velocity.y > 0 ? -1 : 1;
			velocity.y += Time.fixedDeltaTime * value * drag;
			
			if ( Mathf.Abs( velocity.y ) < 1 ) {
				velocity.y = 0;
			}
		}

		velocity.x = Mathf.Clamp( velocity.x, -maxSpeed, maxSpeed );
		velocity.y = Mathf.Clamp( velocity.y, -maxSpeed, maxSpeed );
	}

	void FixedUpdate () {
		rigidbody2D.velocity = velocity;

		Vector2 direction = transform.up;

		if ( velocity.x != 0 ) {
			direction.x = velocity.x;
		}
		if (velocity.y != 0) {
			direction.y = velocity.y;
		}

		rigidbody2D.angularVelocity = 0;
		transform.up = direction;
	}
}
