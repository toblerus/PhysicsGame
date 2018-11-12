using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public bool buttonIsPressed;

    public void Move()
    {
        GetComponent<ConstantForce2D>().enabled = true;
    }

    public void DisableForce()
    {
        GetComponent<ConstantForce2D>().enabled = false;
    }

    public void Update()
    {
        if (buttonIsPressed == true)
        {
            Move();
        }
        else
        {
            DisableForce();
        }
    }

    public void buttonPress() { buttonIsPressed = true; }
    public void buttonUp() { buttonIsPressed = false; }

}
