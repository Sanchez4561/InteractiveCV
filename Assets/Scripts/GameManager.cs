﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isPause;
    public int virusKill;
    public Text missionInfo;

    public GameObject[] wirusSpawn;

    private void Awake()
    {
        instance = this;
        missionInfo.text = "Kill all Bulk Virus";
    }

    private void Update()
    {
        if(virusKill == 5)
        {
            foreach(GameObject spawn in wirusSpawn)
            {
                spawn.SetActive(false);
            }
            missionInfo.text = "Press P to profile";
        }
    }
}
