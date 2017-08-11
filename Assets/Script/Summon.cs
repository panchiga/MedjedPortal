using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour {
    public string myname;

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
            //TODO: もうちょっといい親の名前の教え方ありそう方法
            GameObject clone = Instantiate(Object, transform.position, transform.rotation);

            clone.GetComponent<Summoned>().portalName = myname;

            summonCount++;
        }

        if (summonCount > summonNum) {
            GameObject portal = GameObject.Find(myname);
            GameObject.Destroy(portal, 0.5f);

            Debug.Log("Destroy Portal");
        }
    }
}
