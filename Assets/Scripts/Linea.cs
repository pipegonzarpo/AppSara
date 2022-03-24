using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Linea : MonoBehaviour
{
    public Transform objetivo;
    public float offset = 0.01f;
    LineRenderer l;
    public Transform pivote;
    public int secciones;
    void Start()
    {
        l = GetComponent<LineRenderer>();
        l.positionCount = secciones;
    }
    void Update()
    {
        for (int i = 0; i < secciones; i++)
        {
            transform.LookAt(objetivo);
            transform.localScale = Vector3.one * (transform.position - objetivo.position).magnitude;
            l.SetPosition(i, Curva((float)i/(float)(secciones-1)) + transform.up*offset);
        }
    }

    public Vector3 Curva(float t)
    {
        return (Mathf.Pow(1 - t, 2) * transform.position + 2 * (1 - t) * t * pivote.position + Mathf.Pow(t, 2) * objetivo.position);
    }
}
