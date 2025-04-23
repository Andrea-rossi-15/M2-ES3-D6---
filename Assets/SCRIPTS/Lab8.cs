using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stampa2Precedenti();

        Debug.Log("Partenza-->" + Partenza + "Precedente-->" + (Partenza - 1) + "Precedente-->" + (Partenza - 2));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Stampa2Precedenti()
    {

    }

    int Partenza = 4;
}
