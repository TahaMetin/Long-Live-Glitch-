using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saglik : MonoBehaviour {

    public float can;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ZararAl(float zararMiktari)
    {
        can -= zararMiktari;
        if(can <= 0)
        {
            ObjeyiYokEt();
        }
    }

    public void ObjeyiYokEt()
    {
        Destroy(gameObject);
    }

}
