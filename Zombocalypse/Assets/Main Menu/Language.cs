using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
    int language;

    //0 = english
    //1 = srpski

    public Button b1;
    public Button b2;

    void Start()
    {
        if (!PlayerPrefs.HasKey("jezik"))
        {
            PlayerPrefs.SetInt("jezik", 0);
            Load();
        }

        else
        {
            Load();
        }

        if(language == 0)
        {
            b1.gameObject.SetActive(true);
            b2.gameObject.SetActive(false);
        }
        else
        {
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(true);
        }
    }

    public void English()
    {
        //na srpski
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(true);

        Save();
    }

    public void Srpski()
    {
        //na engleski
        b1.gameObject.SetActive(true);
        b2.gameObject.SetActive(false);

        Save();
    }

    private void Load()
    {
        language = PlayerPrefs.GetInt("jezik");
    }
    private void Save()
    {
        if (language == 0) language = 1;
        else language = 0;

        PlayerPrefs.SetInt("jezik", language);
    }
}
