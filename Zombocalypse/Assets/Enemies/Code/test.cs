using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class test : MonoBehaviour
{
    public GameObject Test;
    public Healthandstuff script;

    // Update is called once per frame
    void Update()
    {
        script = Test.GetComponent<Healthandstuff>();
        Debug.Log(script.startingHealth.ToString());
    }
}
