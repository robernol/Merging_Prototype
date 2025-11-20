using UnityEngine;

public class FireCast : MonoBehaviour
{
    public bool isCasting, x;
    public GameObject a, b, c, d, e, f, g, h, i;
    void Start()
    {
        isCasting = false;
        x = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCasting)
        {
            x = false;
            a.GetComponent<LightUp>().light = true;
            b.GetComponent<LightUp>().light = true;
            c.GetComponent<LightUp>().light = true;
            d.GetComponent<LightUp>().light = true;
            e.GetComponent<LightUp>().light = true;
            f.GetComponent<LightUp>().light = true;
            g.GetComponent<LightUp>().light = true;
            h.GetComponent<LightUp>().light = true;
            i.GetComponent<LightUp>().light = true;
        }
        else if (x == false) 
        {
            x = true;
            a.GetComponent<LightUp>().light = false;
            b.GetComponent<LightUp>().light = false;
            c.GetComponent<LightUp>().light = false;
            d.GetComponent<LightUp>().light = false;
            e.GetComponent<LightUp>().light = false;
            f.GetComponent<LightUp>().light = false;
            g.GetComponent<LightUp>().light = false;
            h.GetComponent<LightUp>().light = false;
            i.GetComponent<LightUp>().light = false;
        }
    }
}
