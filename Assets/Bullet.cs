using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter2D ( Collision2D collider ) {
		Destroy( gameObject );
	}
}
