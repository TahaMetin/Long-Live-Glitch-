using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecenekKontrolu : MonoBehaviour {

    public Slider sesAyari;
    public Slider zorlukAyari;
    public SahneKontrolu sahneYoneticisi;
    private MuzikKontrolu muzikYoneticisi;

    void Start()
    {
        sesAyari.value = OyuncuAyarları.AnaSesiAl();
        zorlukAyari.value = OyuncuAyarları.zorluguAl();
        muzikYoneticisi = GameObject.FindObjectOfType<MuzikKontrolu>();   
    }

    void Update()
    {
        muzikYoneticisi.SesiAyarla(sesAyari.value);
    }

    public void SesiKaydetVeCik()
    {
        OyuncuAyarları.AnaSesiAyarla(sesAyari.value);
        OyuncuAyarları.zorluguAyarla(zorlukAyari.value);
        sahneYoneticisi.IsimleSahneCagırma("1.Menu");
    }

    public void BaslangicAyarlariniUygula()
    {
        sesAyari.value = 0.5f;
        zorlukAyari.value = 2f;
    }


}
