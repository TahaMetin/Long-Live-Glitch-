using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParayiTopla : MonoBehaviour {


    public int toplamPara ;
    
    private Text paraMiktarininGösterimi;
    public enum ObjeOlusturmaDurumu { BASARILI, BASARISIZ };

    
    private void Start()
    {
        paraMiktarininGösterimi = GetComponent<Text>();
        ParayiEkrandaGoster();
    }

    public void ParayiEkle(int paraMiktari)
    {
        toplamPara += paraMiktari;
        ParayiEkrandaGoster();
    }

    public ObjeOlusturmaDurumu ParayiKullan(int savunanObjeninMaliyeti)
    {
        if (toplamPara >= savunanObjeninMaliyeti)
        {
            toplamPara -= savunanObjeninMaliyeti;
            ParayiEkrandaGoster();
            return ObjeOlusturmaDurumu.BASARILI;
        }
        else
        {
            return ObjeOlusturmaDurumu.BASARISIZ;
        }
       
    }

    public void ParayiEkrandaGoster()
    {
        paraMiktarininGösterimi.text = toplamPara.ToString();
    }
}
