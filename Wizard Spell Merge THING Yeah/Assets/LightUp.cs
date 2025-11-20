using UnityEngine;

public class LightUp : MonoBehaviour
{
    public bool light;
    void Start()
    {
        light = false;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void Update()
    {
        if (light)
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        
    }
}
