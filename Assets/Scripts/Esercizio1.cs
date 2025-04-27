using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int num = 0;
    public int index = 10;

    // Start is called before the first frame update
    void Start()
    {
        while (index > 0)
        {

            num++;
            Debug.Log("Il valore di num è " + num);
            index--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
