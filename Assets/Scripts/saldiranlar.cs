using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saldiranlar : MonoBehaviour {

    //[Range(0f,2f)]
    private float suAnkiHiz;
    private GameObject mevcutHedef;
    private Animator objeninAnimatoru;

    [Tooltip("kaç saniyede bir doğacağını buraya giriniz.")]
    public float kacSaniyedeBirDogacak;

	// Use this for initialization
	void Start () {
        
        //Rigidbody2D objeninRigidbodysi = gameObject.AddComponent<Rigidbody2D>();
        //objeninRigidbodysi.isKinematic = true;
        objeninAnimatoru = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * suAnkiHiz * Time.deltaTime);
        if (!mevcutHedef)
        {
            objeninAnimatoru.SetBool("saldiriVarMi",false);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public void SuAnkiHiziAyarla(float hiz)
    {
        suAnkiHiz = hiz;
    }

    public void ZararVer(float zararMiktari)
    {
        if(mevcutHedef)
        {
            Saglik saglik = mevcutHedef.GetComponent<Saglik>();
            if (saglik)
            {
                saglik.ZararAl(zararMiktari);
            }
        }
    }

    public void HedefiBelirle(GameObject hedefimiz)
    {
        mevcutHedef = hedefimiz;
    }
}
