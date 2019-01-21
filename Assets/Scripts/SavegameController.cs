using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavegameController : MonoBehaviour {

    public void SavePlayerProgress(int maxDistance)
    {
        PlayerPrefs.SetInt("highestScore", (int)maxDistance);
    }

    public int LoadSavegame()
    {
        int highestScore = PlayerPrefs.GetInt("highestScore");
        return highestScore;
    }
}
