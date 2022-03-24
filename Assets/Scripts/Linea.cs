using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Linea : MonoBehaviour
{
    public Transform objetivo;
    public float offset = 0.01f;
    LineRenderer l;
    void Start()
    {
        l = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        l.SetPosition(0, transform.position + transform.up * offset);
        l.SetPosition(1, objetivo.position + transform.up * offset);
    }
}
