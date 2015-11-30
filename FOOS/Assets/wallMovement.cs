using UnityEngine;
using System.Collections;

public class wallMovement : MonoBehaviour {
	public Rigidbody wall;
	private bool move;
	// Use this for initialization
	void Start () {
		wall = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {


		if (wall.position.x > 2) {
			move = true;
		}
		if (wall.position.x < -2) {
			move = false;
		}

		if (move) {
			wall.velocity = new Vector3 (wall.velocity.x - 0.005f, wall.velocity.y, wall.velocity.z);

		} else {
			wall.velocity = new Vector3 (wall.velocity.x + 0.005f, wall.velocity.y, wall.velocity.z);

		}
	





	}
}
