using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public int[] arr = {10,20,30,40};

    // Start is called before the first frame update
    void Start()
    {

//#pragma warning disable CS0162 // Unreachable code detected
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[0] + arr[1] + arr[2] + arr[3]);
            Debug.Log(arr[0] * arr[1] * arr[2] * arr[3]);
            if (i == 0)
            {
                break;
            }
            
        }
//#pragma warning restore CS0162 // Unreachable code detected

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
