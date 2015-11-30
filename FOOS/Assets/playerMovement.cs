using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {


	AudioSource audio; 
	private Rigidbody sphere;
    private RPCUpdates gameLogic;

	// Use this for initialization
	void Start () {
        gameLogic = GameObject.Find("GameLogic").GetComponent<RPCUpdates>();
		audio = GetComponent<AudioSource>();
		sphere = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetButtonDown("up")) {
            if (sphere.velocity.z < 14)
                gameLogic.kickBall(this.name, "up", this.transform.position);
				//sphere.addForce(0, 0, 250);
			audio.Play();
		}
		if (Input.GetButtonDown ("down")) {
			if(sphere.velocity.z > -14)
                gameLogic.kickBall(this.name, "down", this.transform.position);
				//sphere.addForce(0, 0, -250);
			audio.Play();
		}
		if (Input.GetButtonDown ("left")) {
			if(sphere.velocity.x > -14)
                gameLogic.kickBall(this.name, "left", this.transform.position);
				//sphere.addForce(-250, 0, 0);
			audio.Play();
		}
		if (Input.GetButtonDown ("right")) {
			if(sphere.velocity.x < 14)
                gameLogic.kickBall(this.name, "right", this.transform.position);
				//sphere.addForce(250, 0, 0);
			audio.Play();
		}
	}
}
