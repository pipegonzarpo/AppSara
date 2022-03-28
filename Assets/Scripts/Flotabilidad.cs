using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotabilidad : MonoBehaviour
{
    public float frecuencia=1;
    public float radio=0.02f;
    Vector3 posInicial;
    float desfase;
    private void Start()
    {
        posInicial = transform.position;
        desfase = Random.Range(-3f, 3f);
    }

    void Update()
    {
        transform.position = posInicial + new Vector3(Mathf.Sin((Time.time + desfase) * frecuencia) * radio, 0, Mathf.Cos((Time.time + desfase) * frecuencia) * radio);
    }
}
