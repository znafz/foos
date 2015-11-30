using UnityEngine;
using System.Collections;

public class EdgeScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -1) {
			this.GetComponent<Rigidbody>().velocity = Vector3.zero;
			this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			if (this.name == "Player1" || this.name == "Player1(Clone)") {
				this.transform.position = new Vector3 (0.0f, 1f, -8.0f);
				GameObject score2 = GameObject.Find("Goal1");
				score2.GetComponent<GoalScript>().score += 1;
				score2.GetComponent<GoalScript>().ModifyText();
			} else {
				this.transform.position = new Vector3 (0.0f, 1f, 8.0f);
				GameObject score1 = GameObject.Find("Goal2");
				score1.GetComponent<GoalScript>().score += 1;
				score1.GetComponent<GoalScript>().ModifyText();
			}
		}
	}
}
