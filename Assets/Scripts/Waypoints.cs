using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{

    public static Transform[] points;
    
    
    void Awake()
    {
        // Criar um array de tamanho igual ao numero de objetos
        points = new Transform[transform.childCount];

        // Colocar cada objeto filho no seu devido espaço dentro do array
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }

    }

   
}
