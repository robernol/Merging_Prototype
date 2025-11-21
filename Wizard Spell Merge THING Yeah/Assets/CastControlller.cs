using UnityEngine;
using UnityEngine.UIElements;

public class CastControlller : MonoBehaviour
{
    public GameObject fire, water, elec, fh, wh, eh;
    public ClickingOn fireSpell, waterSpell, elecSpell;
    public bool f, w, e, f2, w2, e2, maxxed;
    public int spellCounter;
    void Start()
    {
        f = false;
        w = false;
        e = false;
        spellCounter = 0;
        maxxed = false;

        f2 = true;
        w2 = true;
        e2 = true;
    }

    void Update()
    {
        if (fireSpell.clicked)
        {
            f = true;
        }
        else
        {
            f = false;
        }
        if (waterSpell.clicked)
        {
            w = true;
        }
        else
        {
            w = false;
        }
        if (elecSpell.clicked)
        {
            e = true;
        }
        else
        {
            e = false;
        }


        if (spellCounter <= 0)
        {
            spellCounter = 0;
        }

        if ( spellCounter == 2)
        {
            maxxed = true;
        }
        else
        {
            maxxed = false;
        }
        if (spellCounter > 2)
        {
            maxxed = false;
            fireSpell.clicked = false;
            waterSpell.clicked = false;
            elecSpell.clicked = false;
            f = false;
            w = false;
            e = false;
            spellCounter = 0;
            f2 = true;
            w2 = true;
            e2 = true;
            fh.SetActive(false);
            fire.SetActive(false);
            wh.SetActive(false);
            water.SetActive(false);
            eh.SetActive(false);
            elec.SetActive(false);

        }

        if (f && f2 )
        {
            f2 = false;
            if (maxxed)
            {
                fireSpell.clicked = false;
            }
            else
            {
                fh.SetActive(true);
                fire.SetActive(true);
                spellCounter++;
            }
        }
        else if (!f && !f2 )
        {
            f2 = true;
            fh.SetActive(false);
            fire.SetActive(false);
            spellCounter--;
        }

        if (w && w2  )
        {
            w2 = false;
            if (maxxed)
            {
                waterSpell.clicked = false;
            }
            else
            {
                wh.SetActive(true);
                water.SetActive(true);
                spellCounter++;
            }
        }
        else if (!w && !w2)
        {
            w2 = true;
            fh.SetActive(false);
            fire.SetActive(false);
            spellCounter--;
        }

        if (e && e2)
        {
            e2 = false;
            if (maxxed)
            {
                elecSpell.clicked = false;
            }
            else
            {
                eh.SetActive(true);
                elec.SetActive(true);
                spellCounter++;
            }
        }
        else if (!e && !e2)
        {
            e2 = true;
            eh.SetActive(false);
            elec.SetActive(false);
            spellCounter--;
        }
    }
}
