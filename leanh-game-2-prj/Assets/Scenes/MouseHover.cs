using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    public Color startColor;
    public Color hoverColor;
    private Vector3 mOffset;

    //
    bool mouseHover = false;
    private void OnMouseDrag()
    {
       
    }

    private void OnMouseEnter()
    {
        mouseHover = true;
        GetComponent<Renderer>().material.SetColor("_Color",hoverColor);
    }
    private void OnMouseExit()
    {
        mouseHover = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }
   
}
