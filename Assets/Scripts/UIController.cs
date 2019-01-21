using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public SavegameController SavegameController;
    public PlayerController PlayerController;

    public Text CurrentScore;
    public Text HighScore;

	// Use this for initialization
	void Start () {
        HighScore.text = SavegameController.LoadSavegame().ToString();
	}

    private void Update()
    {
        CurrentScore.text = Mathf.RoundToInt(PlayerController.maxDistance).ToString();
    }


}
