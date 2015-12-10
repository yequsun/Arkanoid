using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public int health = 1;

	void Start(){
	}

	void OnCollisionEnter2D(Collision2D collisionInfo) {
		health -= 1;

		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}
