using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D collider) {

		if (collider.gameObject.name.Contains ("Trianlge") ){
			Enemy enemy = collider.gameObject.GetComponent<Enemy>();
			enemy.Kill();
		}

		Destroy( gameObject );
	}
}
