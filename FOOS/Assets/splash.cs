using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {
    private float timer;
	// Use this for initialization
	void Start () {
        timer = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0.0f)
            Destroy(this.gameObject);
        timer -= Time.deltaTime;
	}
}
