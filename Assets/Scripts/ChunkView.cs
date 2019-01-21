using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkView : MonoBehaviour {

    public GameObject[] Prefab1Compatibles;
    public GameObject[] Prefab2Compatibles;
    public GameObject[] Prefab3Compatibles;
    public GameObject[] Prefab4Compatibles;
    public GameObject[] Prefab5Compatibles;
    public GameObject[] Prefab6Compatibles;

    public GameObject[] getCompatibles(string index)
    {
        string caseSwitch = index;

        switch (caseSwitch)
        {
            case "LevelGen1(Clone)":
                return Prefab1Compatibles;
                break;
            case "LevelGen2(Clone)":
                return Prefab2Compatibles;
                break;
            case "LevelGen3(Clone)":
                return Prefab3Compatibles;
                break;
            case "LevelGen4(Clone)":
                return Prefab4Compatibles;
                break;
            case "LevelGen5(Clone)":
                return Prefab5Compatibles;
                break;
            case "LevelGen6(Clone)":
                return Prefab6Compatibles;
                break;
            default:
                return Prefab1Compatibles;
                break;
        }
    }
}
