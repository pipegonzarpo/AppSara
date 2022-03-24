using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamaño : MonoBehaviour
{
    public Transform inicial;
    public Transform final;

    Vector3 pos;
    Vector3 tam;
    void Start()
    {
        pos = Vector3.zero;
        tam = Vector3.one;
    }
    void Update()
    {
        pos.x = inicial.position.x;
        tam.x = final.position.x - inicial.position.x;

        transform.position = pos;
        transform.localScale = tam;
    }
}
