using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Data", menuName = "PlayerData")]
public class PlayerSO : ScriptableObject {
    public float ForceX;
    public float ForceY;
}
