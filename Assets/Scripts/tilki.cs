using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(saldiranlar))]

public class tilki : MonoBehaviour {

    private Animator tilkiAnimator;
    private saldiranlar saldiranObje;


	// Use this for initialization
	void Start () {
        tilkiAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<saldiranlar>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject tilkininEtkilesimeGirdigiObje = collision.gameObject;

        if (!tilkininEtkilesimeGirdigiObje.GetComponent<savunanlar>())
        {
            return;
        }
        else if(tilkininEtkilesimeGirdigiObje.GetComponent<Tas>())
        {
            tilkiAnimator.SetTrigger("ziplamaİslemi");
        }
        else
        {
            tilkiAnimator.SetBool("saldiriVarMi", true);
            saldiranObje.HedefiBelirle(tilkininEtkilesimeGirdigiObje);
        }
    }

}
