using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tempo += Time.deltaTime;
        if (Tempo > 60)
        {
            Debug.Log("Un minuto");
        }

        else if (Tempo > 45)
        {
            Debug.Log("più di 45 sec");
        }

        else if (Tempo > 30)
        {
            Debug.Log("Più di 30 sec");
        }

        else if (Tempo < 30)
        {
            Debug.Log("Meno di 30 sec");
        }

    }

    float Tempo = 0;
}
