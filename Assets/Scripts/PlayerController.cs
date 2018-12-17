using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public PlayerSO playerData;

    public bool ButtonIsPressed;
    public float IncreaseSpeed;

    private float _nextActionTime = 0.0f;
    public float Period = 0.5f;
    private ConstantForce2D _constantForce2D;

    private void Start()
    {
        _constantForce2D = GetComponent<ConstantForce2D>();
    }

    public void Move()
    {
        _constantForce2D.enabled = true;    }

    public void DisableForce()
    {
        GetComponent<ConstantForce2D>().enabled = false;
        GetComponent<ConstantForce2D>().force = new Vector2(playerData.ForceX, playerData.ForceY); //<- put into config (scriptable object)
    }

    public void Update()
    {
        if (ButtonIsPressed == true)
        {
            Move();
            if (Time.time > _nextActionTime)
            {
                _nextActionTime += Period;
                IncreaseGravity();
            }
        }
        else
        {
            DisableForce();
        }
    }

    public void IncreaseGravity()
    {
        GetComponent<ConstantForce2D>().force = new Vector2(0, GetComponent<ConstantForce2D>().force.y - 1);
    }

    public void ButtonPress() { ButtonIsPressed = true; }
    public void ButtonUp() { ButtonIsPressed = false; }

}