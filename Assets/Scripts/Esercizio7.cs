using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    public int[] arrayProva = new int[20];
    // Start is called before the first frame update
    void Start()
    {
        

        StampaArray("Array precedente", arrayProva);

        GeneraArray(arrayProva, 25, 500);

        StampaArray("Array aggiornato", arrayProva);

        int somma= SommaArray(arrayProva);

        Debug.Log(somma);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GeneraArray(int[] tuoArray, int valoreMinimo, int valoreMassimo)
    {
        //generare array che restituisce un array di 20 elementi con valori casuali tra 1 e 100
        if (tuoArray == null) {
            Debug.Log("l'array fornito è nullo");
            return;
        }



        for (int i = 0; i < tuoArray.Length; i++)
        {
            tuoArray[i] = Random.Range(valoreMinimo, valoreMassimo + 1);
        }
        
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

        for (int i = 0; i < arrayDaStampare.Length; i++)
        {
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
