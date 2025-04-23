using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab6 : MonoBehaviour
{

    public int a = 7;
    // Start is called before the first frame update
    void Start()
    {
        if (a % 2 == 0)
        {
            Debug.Log("è pari");



        }
        else
        {
            Debug.Log("è dispari");
        }
        if (a > 10)
        {
            Debug.Log("maggiore di dieci");

        }

        else
        {
            Debug.Log("minore di dieci");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
