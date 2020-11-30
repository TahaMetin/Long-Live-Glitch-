using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuncuAyarları : MonoBehaviour {

    const string ANA_SES_ANAHTARI = "ana_ses";
    const string ZORLUK_ANAHTARI = "zorluk";
    const string SEVIYE_ANAHTARI = "seviye_acik_";
    //seviye_acik_0         seviye_acik_1       vb.


    public static void AnaSesiAyarla(float ses)
    {
        if (ses >= 0f && ses <= 1f)
        {
            PlayerPrefs.SetFloat(ANA_SES_ANAHTARI, ses);
        }
        else
        {
            Debug.LogError("0-1 aralığı dışında bir değer girdiniz.");
        }
    }

    public static float AnaSesiAl()
    {
        return PlayerPrefs.GetFloat(ANA_SES_ANAHTARI);
    }

    public static void SeviyeninKilidi(int seviye)
    {
        if (seviye < SceneManager.sceneCountInBuildSettings)
        {
            PlayerPrefs.SetInt(SEVIYE_ANAHTARI+seviye.ToString(), 1);
        }
        else
        {
            Debug.LogError("Oyunda olmayan bir sahne açılamaz.");
        }
    }

    public static bool SeviyeAcikMi(int seviye)
    {
        int seviyeDegeri = PlayerPrefs.GetInt(SEVIYE_ANAHTARI + seviye.ToString());

        bool SeviyeAcikMi = (seviyeDegeri == 1);

        if (seviye< SceneManager.sceneCountInBuildSettings)
        {
            return SeviyeAcikMi;
        }
        else
        {
            Debug.LogError("Oyunda olmayan bir seviyenin kilidin sorgulayamazsın.");
            return false;

        }
    }

    public static void zorluguAyarla(float zorluk)
    {
        if (zorluk >= 1f && zorluk <= 5f)
        {
            PlayerPrefs.SetFloat(ZORLUK_ANAHTARI, zorluk);
        }
        else
        {
            Debug.LogError("zorluk seviyesi 1-5 arasında olmadılıdır.");
        }
    }

    public static float zorluguAl()
    {
        return PlayerPrefs.GetFloat(ZORLUK_ANAHTARI);   
    }



}
