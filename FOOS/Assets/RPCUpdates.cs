using UnityEngine;
using System.Collections;

public class RPCUpdates : MonoBehaviour {
    private NetworkView nV;
    // Use this for initialization
    void Start() {
        nV = this.GetComponent<NetworkView>();

    }
    public void kickBall(string player, string direction, Vector3 pos)
    {
        nV.RPC("kickBallRPC", RPCMode.All, player, direction, pos);
    }
    [RPC]
    void kickBallRPC(string player, string direction, Vector3 pos)
    {
        GameObject sphere = GameObject.Find(player);
        sphere.transform.position = pos;
        if (direction == "up")
        {

            sphere.GetComponent<Rigidbody>().AddForce(0, 0, 250);
        }
        if (direction == "down")
        {
            sphere.GetComponent<Rigidbody>().AddForce(0, 0, -250);
        }
        if (direction == "left")
        {
            sphere.GetComponent<Rigidbody>().AddForce(-250, 0, 0);
        }
        if (direction == "right")
        {
            sphere.GetComponent<Rigidbody>().AddForce(250, 0, 0);
        }
    }

    public void moveWall(Vector3 pos)
    {
        nV.RPC("moveWallRPC", RPCMode.All, pos);
    }

    [RPC]
    void moveWallRPC(Vector3 pos)
    {        
        GameObject wall = GameObject.Find("movingWall(Clone)");
        wall.GetComponent<Rigidbody>().position = pos;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
