using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamaño : MonoBehaviour
{
    public Transform hInicial;
    public Transform hFinal;
    public Transform vInicial;
    public Transform vFinal;
    public Transform pInicial;
    public Transform pFinal;

    Vector3 pos;
    Vector3 tam;
    void Start()
    {
        pos = Vector3.zero;
        tam = Vector3.one;
    }
    void Update()
    {
        pos.x = hInicial.position.x;
        tam.x = hFinal.position.x - hInicial.position.x;

        pos.y = vInicial.position.y;
        tam.y = vFinal.position.y - vInicial.position.y;

        pos.z = pInicial.position.z;
        tam.z = pFinal.position.z - pInicial.position.z;

        transform.position = pos;
        transform.localScale = tam;

        UbicarAnclas();
    }

    void UbicarAnclas()
    {
        Vector3 pos = vInicial.position;
        pos.x = hInicial.position.x + (hFinal.position.x - hInicial.position.x) / 2;
        vInicial.position = pos;
        pos.y = vFinal.position.y;
        vFinal.position = pos;
        pos.z = pFinal.position.z;
       /// pFinal.position = p

        pos = hInicial.position;
        pos.y = vInicial.position.y + (vFinal.position.y - vInicial.position.y) / 2;
        hInicial.position = pos;
        pos.x = hFinal.position.x;
        hFinal.position = pos;
    }
}
