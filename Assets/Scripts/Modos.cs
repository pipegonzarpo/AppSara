using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modos : MonoBehaviour
{
    public static Modos singleton;
    public Estados modo;
    private void Awake()
    {
        singleton = this;
    }
    public void CambiarModo(Estados e)
    {
        modo = e;
    }
}

public enum Estados
{
    general,
    basico,
    intermedio,
    avanzado
}
