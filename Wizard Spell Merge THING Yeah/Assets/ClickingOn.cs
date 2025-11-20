using JetBrains.Annotations;
using UnityEngine;

public class ClickingOn : MonoBehaviour
{
    public GameObject grid, highlight;
    public bool clicked;

    // Update is called once per frame
    void Start()
    {
        clicked = false;
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            highlight.SetActive(true);
            grid.SetActive(true);
            clicked = true;
        }
        else
        {
            highlight.SetActive(false);
            grid.SetActive(false);
            clicked = false;
        }
    }
}
