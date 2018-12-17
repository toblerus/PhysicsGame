using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;
	
	void Update ()
    {
        Camera.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y, -10);
	}
}
