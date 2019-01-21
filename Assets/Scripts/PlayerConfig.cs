using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Data", menuName = "PlayerData")]
public class PlayerConfig : ScriptableObject {
    public float ForceX;
    public float ForceY;
    public int loseCondition;
    public float Period;
}
