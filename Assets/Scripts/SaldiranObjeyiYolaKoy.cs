using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranObjeyiYolaKoy : MonoBehaviour
{


    public GameObject[] saldiranObjelerinPrefabi;

    

    private void Update()
    {
     
        foreach (GameObject saldiranObjeninPrefabi in saldiranObjelerinPrefabi)
        {
            if (SaldiriVaktiMi(saldiranObjeninPrefabi))
            {
                saldiranObjeyiYolaYerlestir(saldiranObjeninPrefabi);
            }
        }
    }

    void saldiranObjeyiYolaYerlestir(GameObject saldiranObje)
    {
        GameObject saldiranObjemiz = Instantiate(saldiranObje) as GameObject;
        saldiranObjemiz.transform.parent = transform;
        saldiranObjemiz.transform.position = transform.position;
    }

    bool SaldiriVaktiMi(GameObject saldiranObje)
    {
        saldiranlar saldiriYapanObje = saldiranObje.GetComponent<saldiranlar>();
        float dogmaBeklemeSuresi = saldiriYapanObje.kacSaniyedeBirDogacak;
        float dogmaBeklemeOrani = 1 / dogmaBeklemeSuresi;

        float sonOran = dogmaBeklemeOrani * Time.deltaTime;

        if (Random.value < sonOran)
        {
            return true;
        }
        else
        {
            return false;
        }

    }



}
