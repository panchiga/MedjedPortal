using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoned : MonoBehaviour {
    GameObject portal;

	void Start ()
    {
        //召喚元のサイズに合わせてオブジェクトのサイズを変える
        portal = GameObject.Find("Portal");

        Vector3 portalSize = portal.transform.localScale;

        transform.localScale = portalSize / 2;

        //アタッチされてるオブジェクトを勢い良く飛ばす
        Rigidbody rb = GetComponent<Rigidbody> ();

        rb.AddForce(Vector3.back * 20f);
    }
	
}
