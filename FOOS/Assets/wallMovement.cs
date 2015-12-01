using UnityEngine;
using System.Collections;

public class wallMovement : MonoBehaviour {
	public Rigidbody wall;
	private bool move;
    NetworkView nv;
    private RPCUpdates gameLogic;
    // Use this for initialization
    void Start () {
		wall = GetComponent<Rigidbody> ();
        gameLogic = GameObject.Find("GameLogic").GetComponent<RPCUpdates>();
    }

	// Update is called once per frame
	void Update () {

        if (Network.isClient)
        {
            if (wall.position.x > 2)
            {
                move = true;
            }
            if (wall.position.x < -2)
            {
                move = false;
            }

            if (move)
            {
                wall.position = new Vector3(wall.position.x - 0.05f, wall.position.y, wall.position.z);

            }
            else
            {
                wall.position = new Vector3(wall.position.x + 0.05f, wall.position.y, wall.position.z);
            }

            gameLogic.moveWall(wall.position);
        }
	
        




	}
}
