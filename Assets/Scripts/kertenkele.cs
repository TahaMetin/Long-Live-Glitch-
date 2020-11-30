using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(saldiranlar))]

public class kertenkele : MonoBehaviour
{

    private Animator kertenkeleAnimator;
    private saldiranlar saldiranObje;


    // Use this for initialization
    void Start()
    {
        kertenkeleAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<saldiranlar>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject kertenekeleninEtkilesimeGirdigiObje = collision.gameObject;

        if (!kertenekeleninEtkilesimeGirdigiObje.GetComponent<savunanlar>())
        {
            return;
        }
        else
        {
            kertenkeleAnimator.SetBool("saldiriVarMi", true);
            saldiranObje.HedefiBelirle(kertenekeleninEtkilesimeGirdigiObje);
        }
    }

}
