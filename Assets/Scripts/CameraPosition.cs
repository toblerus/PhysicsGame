using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {

    public GameObject Camera;
    public GameObject Player;
	
	// Update is called once per frame
	void Update () {
        Camera.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y, -10);
	}
}
