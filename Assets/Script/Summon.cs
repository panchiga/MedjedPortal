﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour {

    public GameObject Object;
    public int summonNum;
    private int summonCount;

	// Use this for initialization
	void Start () {

        //summonNum回Objectを召喚
        InvokeRepeating("SummonObject", 1.0f, 0.3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SummonObject() {
        if (summonCount <= summonNum)
        {
            //ObjectのInstance作成
            Instantiate(Object, Vector3.forward, Quaternion.identity);
            
            summonCount++;
        }
    }
}