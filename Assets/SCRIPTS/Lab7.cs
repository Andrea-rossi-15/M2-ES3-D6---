using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Lab7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stampa2Successivo();

    }




    // Update is called once per frame
    void Update()
    {

    }

    void Stampa2Successivo()
    {
        Debug.Log("Partenza-->" + Partenza + "Successivo-->" + (Partenza + 1) + "Sucessivo-->" + (Partenza + 2));
    }

    public int Partenza = 4;

}



