using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public Image On;
    public Image Off;
    int index;

    void Start()
    {
        if (!PlayerPrefs.HasKey("switch"))
        {
            PlayerPrefs.SetInt("switch", 1);
            Load();
        }

        else
        {
            Load();
        }

        if(index == 0)
        {
            On.gameObject.SetActive(true);
            Off.gameObject.SetActive(false);
        }
        else
        {
            On.gameObject.SetActive(false);
            Off.gameObject.SetActive(true);
        }
        
    }
    public void ON()
    {
        On.gameObject.SetActive(false);
        Off.gameObject.SetActive(true);

        Save();
    }
    public void OFF()
    {
        On.gameObject.SetActive(true);
        Off.gameObject.SetActive(false);

        Save();
    }

    private void Load()
    {
        index = PlayerPrefs.GetInt("switch");
    }
    private void Save()
    {
        if (index == 0) index = 1;
        else index = 0;
        PlayerPrefs.SetInt("switch", index);
    }
}
