using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermiler : MonoBehaviour {

    public float hiz, verdigiZarar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * hiz * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        saldiranlar saldiranObje = collision.gameObject.GetComponent<saldiranlar>();
        Saglik saldiranObjeninCani = collision.gameObject.GetComponent<Saglik>();

        if (saldiranObje && saldiranObjeninCani)
        {
            saldiranObjeninCani.ZararAl(verdigiZarar);
            Destroy(gameObject);
        }
    }
}
