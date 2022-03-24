using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    public Transform[] pivotes;
    public float velocidad;
    public int indice;
    public GameObject[] estados;

    private void Start()
    {
        CambiarPivote(0);
    }
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, pivotes[indice].rotation, velocidad * Time.deltaTime);
    }

    public void CambiarPivote(int k)
    {
        indice = k;
        for (int i = 0; i < estados.Length; i++)
        {
            estados[i].SetActive(i == k);
        }
    }
}
