using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public float velocidadRotacion;
    public Vector3 angulos;
    public Vector3 angulosSnapped;
    public float diferencia;

    public int anguloSnap = 15;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            angulos.y += velocidadRotacion * Time.deltaTime * Input.GetAxis("Mouse X");
            diferencia = Mathf.Abs(Mathf.Abs(angulos.y) % 90);

            if (diferencia < anguloSnap || diferencia > 90-anguloSnap)
            {
                angulosSnapped.y = 90 * (Mathf.RoundToInt(angulos.y / 90));
            }
            else
            {
                angulosSnapped = angulos;
            }

            angulos.x -= velocidadRotacion * Time.deltaTime * Input.GetAxis("Mouse Y");
            diferencia = Mathf.Abs(Mathf.Abs(angulos.x) % 90);
            if (diferencia < anguloSnap || diferencia > 90 - anguloSnap)
            {
                angulosSnapped.x = 90 * (Mathf.RoundToInt(angulos.x / 90));
            }
            else
            {
                angulosSnapped.x = angulos.x;
            }

            transform.eulerAngles = angulosSnapped;
        }
    }
}
