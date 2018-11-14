using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public bool buttonIsPressed;
    public float IncreaseSpeed;

    private float nextActionTime = 0.0f;
    public float period = 0.5f;

    public void Move()
    {
        GetComponent<ConstantForce2D>().enabled = true;    }

    public void DisableForce()
    {
        GetComponent<ConstantForce2D>().enabled = false;
        GetComponent<ConstantForce2D>().force = new Vector2(0, -5);
    }

    public void Update()
    {
        if (buttonIsPressed == true)
        {
            Move();
            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                increaseGravity();
            }
        }
        else
        {
            DisableForce();
        }
    }

    public void increaseGravity()
    {
        GetComponent<ConstantForce2D>().force = new Vector2(0, GetComponent<ConstantForce2D>().force.y - 1);
    }

    public void buttonPress() { buttonIsPressed = true; }
    public void buttonUp() { buttonIsPressed = false; }

}