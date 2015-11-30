using UnityEngine;
using System.Collections;

public class player2Movement : MonoBehaviour {
	
	AudioSource audio;
	private Rigidbody sphere;
	
	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();
		sphere = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp("w")) {
			if(sphere.velocity.z < 14)
				sphere.AddForce(0, 0, 250);
			audio.Play();
		}
		if (Input.GetKeyUp ("s")) {
			if(sphere.velocity.z > -14)
				sphere.AddForce(0, 0, -250);
			audio.Play();
		}
		if (Input.GetKeyUp ("a")) {
			if(sphere.velocity.x > -14)
				sphere.AddForce(-250, 0, 0);
			audio.Play();
		}
		if (Input.GetKeyUp ("d")) {
			if(sphere.velocity.x < 14)
				sphere.AddForce(250, 0, 0);
			audio.Play();
		}
	}
}
