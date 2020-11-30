using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrolu : MonoBehaviour {

    public float sonrakiSahneninYuklenmeSuresi;
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "0.Menuden onceki sahne")
        {
            Invoke("sonrakiSahne", sonrakiSahneninYuklenmeSuresi);
        }
        
    }

    public void sonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void oyundanCikis()
    {
        Application.Quit();
    }

    public void IsimleSahneCagırma(string sahneIsmi)
    {
        SceneManager.LoadScene(sahneIsmi);
    }

    public void IndexleSahneCagirma(int sahneIndexi)
    {
        SceneManager.LoadScene(sahneIndexi);
    }


}
