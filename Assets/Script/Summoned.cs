using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoned : MonoBehaviour {
    
	void Start ()
    {
        Debug.Log("Summoned!");

        //アタッチされてるオブジェクトを勢い良く飛ばす
        Rigidbody rb = GetComponent<Rigidbody> ();

        rb.AddForce(Vector3.left * 10f);
        Debug.Log("Summoned!");
    }
	
}
