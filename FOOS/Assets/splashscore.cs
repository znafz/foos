using UnityEngine;
using System.Collections;

public class splashscore : MonoBehaviour {

    private float timer;
    // Use this for initialization
    void Start()
    {
        timer = 3.0f;
        this.gameObject.GetComponent<TextMesh>().text = "";
    }


    // Update is called once per frame
    void Update()
    {
        if (timer <= 0.0f)
            this.gameObject.GetComponent<TextMesh>().text = "test";
        else
            this.gameObject.GetComponent<TextMesh>().text = "";
        timer -= Time.deltaTime;
    }
}
