using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab9 : MonoBehaviour
{






    // Start is called before the first frame update
    void Start()
    {
        MaggioreTra2();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void MaggioreTra2()
    {

        if (a > b)
        {
            Debug.Log("a è maggiore di b");
        }
        else
        {
            Debug.Log("b è maggiore di a");
        }
    }

    public int a = 5;
    public int b = 10;
}

