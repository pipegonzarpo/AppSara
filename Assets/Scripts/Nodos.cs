using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Nodos : MonoBehaviour
{
    public static Nodos nodoActual;
    public GameObject letrero;
    public Estados estado;
    public static Estados modo;
    public static Estados estadoActual;
    public Material materialNormal;
    public Material materialCambio;
    public MeshRenderer mr;
    public UnityEvent eventoClick;
    //public bool cambia;

    void Start()
    {
        mr = GetComponentInChildren<MeshRenderer>();
        if (materialNormal == null)
        {
            materialNormal = mr.material;
        }
    }

    // Update is called once per frame
    void Update()
    {
        letrero.SetActive(nodoActual == this);
        if (estadoActual == estado)
        {
            mr.material = materialNormal;
        }
        else
        {
            mr.material = materialCambio;
        }
    }

    private void OnMouseUp()
    {
        nodoActual = this;
        estadoActual = estado;
        eventoClick.Invoke();
    }
}
