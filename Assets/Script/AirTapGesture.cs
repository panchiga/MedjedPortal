
using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AirTapGesture : MonoBehaviour, IInputClickHandler
{
    public GameObject obj;
    public GameObject gaze;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData) { 
        GameObject clone = Instantiate(obj, gaze.GetComponent<Transform>().position, gaze.GetComponent<Transform>().rotation);

        clone.GetComponent<Summon>().myname = clone.name;
    }
}
