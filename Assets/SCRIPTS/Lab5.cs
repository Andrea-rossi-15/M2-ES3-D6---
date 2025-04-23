using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5 : MonoBehaviour
{
    public int a = 10;
    public int b = 5;
    public int c = 15;
    public int d = 20;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a + b + c + d);
        Debug.Log(a * b * c * d);
        Debug.Log((a + b + c + d) / 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
