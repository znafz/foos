using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {


	AudioSource audio; 
	private Rigidbody sphere;

	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();
		sphere = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp("up")) {
			if(sphere.velocity.z < 14)
				sphere.AddForce(0, 0, 250);
			audio.Play();
		}
		if (Input.GetKeyUp ("down")) {
			if(sphere.velocity.z > -14)
				sphere.AddForce(0, 0, -250);
			audio.Play();
		}
		if (Input.GetKeyUp ("left")) {
			if(sphere.velocity.x > -14)
				sphere.AddForce(-250, 0, 0);
			audio.Play();
		}
		if (Input.GetKeyUp ("right")) {
			if(sphere.velocity.x < 14)
				sphere.AddForce(250, 0, 0);
			audio.Play();
		}
	}
}
