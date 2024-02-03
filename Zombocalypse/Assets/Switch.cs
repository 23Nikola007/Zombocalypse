using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public Image On;
    public Image Off;
    int index;

    public void ON()
    {
        On.gameObject.SetActive(false);
        Off.gameObject.SetActive(true);
    }
    public void OFF()
    {
        On.gameObject.SetActive(true);
        Off.gameObject.SetActive(false);
    }
}
