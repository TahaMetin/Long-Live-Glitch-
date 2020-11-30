using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KazanmKontrolu : MonoBehaviour {


	void Update ()
    {
        GetComponent<Slider>().value -= 0.0025f;

        if(GetComponent<Slider>().value <=0)
        {
            GetComponent<Slider>().value = 1f;
            SceneManager.LoadScene("5.Kazanma");
            
        }
	}
}
