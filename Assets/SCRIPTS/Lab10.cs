using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MinoreTra2();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MinoreTra2()
    {
        if (a < b)
        {
            Debug.Log("a è minore di b");
        }
        else
        {
            Debug.Log("b è minore di a");
        }
    }

    public int a = 10;
    public int b = 20;
}
