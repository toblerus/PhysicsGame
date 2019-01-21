﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public int LevelLength;
    public GameObject LevelParent;
    public GameObject[] LevelPrefabs; //Array of JunkView (Ask which prefabs fit to previous ones and take one from those
    public GameObject[] LevelStartPrefabs;

    public Vector3 InitialPos = new Vector3(1.5f, -1.5f, 0.0f);
    public Vector3 CurrentPos;
    public Vector3 Offset = new Vector3(3.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start ()
    {
        GenerateLevel();

    }
	
    public void GenerateLevel()
    {
        CurrentPos = InitialPos;
        int StartPrefabIndex = Random.Range(0, LevelStartPrefabs.Length);
        var InstantiatedStart = Instantiate(LevelStartPrefabs[StartPrefabIndex], CurrentPos, Quaternion.identity);
        CurrentPos = CurrentPos + Offset;
        InstantiatedStart.transform.parent = LevelParent.transform;

        for (int i = 0; i <= LevelLength; i++)
        {
            int LevelPrefabIndex = Random.Range( 0, LevelPrefabs.Length);
            //Debug.Log(LevelPrefabIndex);
            var InstantiatedObject = Instantiate(LevelPrefabs[LevelPrefabIndex], CurrentPos, Quaternion.identity);
            CurrentPos = CurrentPos + Offset;
            InstantiatedObject.transform.parent = LevelParent.transform;
        }
    }
}
