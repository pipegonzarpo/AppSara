using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickAccion : MonoBehaviour
{
    public UnityEvent eventoClick;

    private void OnMouseUp()
    {
        eventoClick.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
