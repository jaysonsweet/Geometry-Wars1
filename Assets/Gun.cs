using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public Transform bulletPrefab;
	public float fireRate;
	private float fireTime;
	public int bulletCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		fireTime -= Time.deltaTime;

		if ( fireTime <= 0 ) {

			GameObject newBullet = Instantiate( bulletPrefab.gameObject ) as GameObject;

			float flip = bulletCount % 2 == 0 ? -0.1f : 0.1f;

			Vector2 local = new Vector2( flip, 1 );
			Vector2 world = transform.TransformPoint( local );

			newBullet.transform.position = world;

			newBullet.rigidbody2D.velocity = transform.parent.rigidbody2D.velocity + ( Vector2 )transform.up * 10;
			newBullet.transform.up = transform.up;

			fireTime = fireRate;
			bulletCount++;
		}
	}
}
