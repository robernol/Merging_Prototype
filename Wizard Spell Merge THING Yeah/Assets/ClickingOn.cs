using JetBrains.Annotations;
using UnityEngine;

public class ClickingOn : MonoBehaviour
{
    public GameObject grid, highlight, caster;
    public bool clicked;

    void Start()
    {
        clicked = false;
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            clicked = true;
        }
        else
        {
            clicked = false;
        }
    }
}
