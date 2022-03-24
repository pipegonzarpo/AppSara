using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitch : MonoBehaviour
{
    public Sprite spCambio;

    Sprite spOriginal;
    SpriteRenderer spRenderer;
    void Start()
    {
        spRenderer = GetComponent<SpriteRenderer>();
        spOriginal = spRenderer.sprite;
    }

    void FixedUpdate()
    {
        if (Dragging.singleton.target == transform.parent.gameObject || Dragging.singleton.target == gameObject)
        {
            spRenderer.sprite = spOriginal;
        }
        else
        {
            spRenderer.sprite = spCambio;
        }
    }
}
