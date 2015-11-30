using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour {
	public int playernum;
	public int score;
	public Text HUDElement;
	public Text Win;
    AudioSource audio;
    // Use this for initialization
    private float timer;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        score = 0;
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        
		if (score >= 5) {
			Win.text = "Player " + playernum.ToString() + " Wins!";
		}
        if (timer >= 3.0f)
            HUDElement.text = "Player " + playernum.ToString() + " Score: " + score.ToString();
        else HUDElement.text = "";
        timer += Time.deltaTime;
	}

	public void ModifyText(){
		HUDElement.text = "Player " + playernum.ToString() + " Score: " + score.ToString();
	}

	void OnTriggerEnter(Collider col){

		col.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		col.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		if (col.name == "Player1" || col.name == "Player1(Clone)") {
			col.transform.position = new Vector3 (0.0f, 1f, -8.0f);
            audio.Play();
			if(playernum == 1)score++;

		} else {
			col.transform.position = new Vector3 (0.0f, 1f, 8.0f);
            audio.Play();
            if (playernum == 2)score++;
		}
		HUDElement.text = "Player " + playernum.ToString() + " Score: " + score.ToString();
	}
}
