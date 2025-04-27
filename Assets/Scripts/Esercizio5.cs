using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    [SerializeField]
    [Range(0,100)]
    public int find = 7;
    public int[] arr = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        int FindintoArr = Random.Range(0,arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
           if (i == FindintoArr)
            {
                arr[i] = find;
               
            }
            else
            {
                arr[i] = Random.Range(0, 101);
            }
                
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (find == arr[i])
            {
                Debug.Log("Found");
            }
            else if (find != arr[i]) {
                Debug.Log("Not Found");
            }
                
        }

        Debug.Log("iterations finished");


    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
