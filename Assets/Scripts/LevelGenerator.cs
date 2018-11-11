using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public int LevelLength;
    public GameObject LevelParent;
    public GameObject[] LevelPrefabs;

	// Use this for initialization
	void Start ()
    {
        GenerateLevel();

    }
	
    public void GenerateLevel()
    {
        for (int i = 0; i <= LevelLength; i++)
        {
            float LevelPrefabIndex = Random.Range(float 0,float 1)*10;
            Debug.Log(LevelPrefabIndex);
            //test
        }
    }
}
