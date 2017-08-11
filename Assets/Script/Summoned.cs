using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoned : MonoBehaviour {
    public GameObject portal;
    public string portalName;

	void Start ()
    {
        //召喚元のサイズに合わせてオブジェクトのサイズを変える
        portal = GameObject.Find(portalName);

        Vector3 portalSize = portal.transform.localScale;

        transform.localScale = portalSize / 2;

        //アタッチされてるオブジェクトを勢い良く飛ばす
        Rigidbody rb = GetComponent<Rigidbody> ();

        rb.AddForce(portal.transform.forward * 5f);
    }
	
}
