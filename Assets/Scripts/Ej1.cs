using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    [SerializeField] int[] arrayDePuntajes = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El indice con menor puntaje es " + ObtenerMenorPuntaje());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {
        int mayorNum = 0;

        foreach (int num in arrayDePuntajes)
        {
            if(num > mayorNum)
            {
                mayorNum = num;
            }
        }
        return mayorNum;
    }

    int ObtenerMenorPuntaje()
    {
        int levelIndex = 0;
        int menorPuntaje = arrayDePuntajes[0];
        for (int i = 1; i < arrayDePuntajes.Length; i++)
        {
            if (arrayDePuntajes[i] < menorPuntaje)
            {
                levelIndex = i;
                menorPuntaje = arrayDePuntajes[i];
            }
        }
        return levelIndex;
    }
}
