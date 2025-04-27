using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    private int[] arrayGenerato;
    // Start is called before the first frame update
    void Start()
    {
        arrayGenerato = GeneraArray();

        StampaArray("Array Generato", arrayGenerato);

        int somma = SommaArray(arrayGenerato);

        Debug.Log($"La somma degli elementi dell'array è: {somma}");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int[] GeneraArray()
    {
        //generare array che restituisce un array di 20 elementi con valori casuali tra 1 e 100
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(0,101);
        }
        return arr;
    }

    public int SommaArray(int[] arrayInput)
    {
        //Somma tutti i valori di un array
        if (arrayInput == null || arrayInput.Length == 0)
        {
            return 0;
        }
        int sommaCorrente = 0;
        foreach (int numero in arrayInput) 
        { 
            sommaCorrente += numero;
        }
        return sommaCorrente;

    }

    public void StampaArray(string messaggio, int[] arrayDaStampare)
    {
        if (arrayDaStampare == null)
        {
            Debug.Log($"{messaggio}: Array nullo.");
            return;
        }
        string contenuto = $"{messaggio}: [";
        
        for (int i = 0; i < arrayDaStampare.Length; i++) {
            contenuto += arrayDaStampare[i];

            if (i < arrayDaStampare.Length - 1)
            {
                contenuto += ", ";
            }
        }
        contenuto += "]";
        Debug.Log(contenuto);
    }
}
