using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectAtatch : MonoBehaviour {
    public GameObject effect;
    public GameObject obj;
	// Use this for initialization
	void Start () {
        obj = GameObject.Instantiate(effect, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
