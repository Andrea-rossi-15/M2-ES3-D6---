using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (voto >= 10)
        {
            Debug.Log("A+");
        }
        else if (voto >= 9)
        {
            Debug.Log("A");
        }
        else if (voto >= 7.8)
        {
            Debug.Log("B");
        }
        else if (voto >= 6)
        {
            Debug.Log("C");
        }
        else if (voto >= 5)
        {
            Debug.Log("E");
        }
        else if (voto >= 0.4)
        {
            Debug.Log("F");
        }
        else if (voto < 0.4)
        {
            Debug.Log("NC");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    [Range(0, 10)]
    public float voto = 0;
}
