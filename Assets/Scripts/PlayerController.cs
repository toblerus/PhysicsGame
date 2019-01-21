using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject RestartButton;
    public PlayerConfig playerData;

    public SavegameController SavegameController;


    private bool _buttonIsPressed;
    private float _increaseSpeed;

    private float _nextActionTime = 0.0f;
    private float _period;  
    private ConstantForce2D _constantForce2D;

    public float maxDistance;
    private int loseCondition; 

    private void Start()
    {
        _period = playerData.Period;
        loseCondition = playerData.loseCondition;
        _constantForce2D = GetComponent<ConstantForce2D>();
    }

    public void Move()
    {
        _constantForce2D.enabled = true;
    }

    public void DisableForce()
    {
        _constantForce2D.enabled = false;
        _constantForce2D.force = new Vector2(playerData.ForceX, playerData.ForceY);
    }

    public void Update()
    {
        CheckLose();

        if (Input.touchCount > 0)
        {
            
            Touch touch = Input.GetTouch(0);
            if (touch.phase != TouchPhase.Moved || touch.phase != TouchPhase.Stationary)
            {
                Move();
                if (Time.time > _nextActionTime)
                {
                    _nextActionTime += _period;
                    IncreaseGravity();
                }
            }
        }
        else
        {
            DisableForce();
        }
    }

    public void IncreaseGravity()
    {
        _constantForce2D.force -= Vector2.up * 1;
    }

    public void ButtonPress() { _buttonIsPressed = true; }
    public void ButtonUp() { _buttonIsPressed = false; }

    public void CheckLose()
    {
        maxDistance = Mathf.Max(maxDistance, transform.position.x);
        if (maxDistance - transform.position.x >= loseCondition)
        {
            SavegameController.SavePlayerProgress((int)maxDistance);
            Debug.Log("You Lost");
            RestartButton.SetActive(true);
            Time.timeScale = 0.0f;
            this.enabled = false;
        }
    }

    
}

internal class SerializedFieldAttribute : Attribute
{
}