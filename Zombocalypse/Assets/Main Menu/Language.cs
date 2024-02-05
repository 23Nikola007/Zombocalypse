using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    bool language;
    //false = english
    //true = srpski

    public TMP_Text srpski;
    public TMP_Text english;

    public TMP_Text srpski2;
    public TMP_Text english2;

    public Button b1;
    public Button b2;

    void Start()
    {
        if(!language)
        {
            English();
            language = true;
        }
        else
        {
            Srpski();
            language = false;
        }
    }

    public void English()
    {
        //prebacuje na srpski
        srpski2.gameObject.SetActive(true);
        english2.gameObject.SetActive(true);

        srpski.gameObject.SetActive(false);
        english.gameObject.SetActive(false);

        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(true);
    }
    public void Srpski()
    {
        //prebacuje na engleski
        srpski.gameObject.SetActive(true);
        english.gameObject.SetActive(true);

        srpski2.gameObject.SetActive(false);
        english2.gameObject.SetActive(false);

        b1.gameObject.SetActive(true);
        b2.gameObject.SetActive(false);
    }
}
