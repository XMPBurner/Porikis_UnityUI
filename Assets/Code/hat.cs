using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hat : MonoBehaviour
{
    public int a = 0;
    public GameObject right;
    public GameObject left;
    public GameObject hat1;
    public GameObject hat2;
    public GameObject hat3;

    public bool hat1on;
    public bool hat2on;
    public bool hat3on;


public void clickright()
{
    a += 1;
}

public void clicleft()
{
    a -= 1;
}

void Update()
{
    if(a == 0)
    {
        hat1on = false;
        hat2on = false;
        hat3on = false;
        hat1.SetActive(hat1on);
        hat2.SetActive(hat2on);
        hat3.SetActive(hat3on);
    }
        if(a == 1)
    {
        hat1on = true;
        hat2on = false;
        hat3on = false;
        hat1.SetActive(hat1on);
        hat2.SetActive(hat2on);
        hat3.SetActive(hat3on);
    }
        if(a == 2)
    {
        hat1on = false;
        hat2on = true;
        hat3on = false;
        hat1.SetActive(hat1on);
        hat2.SetActive(hat2on);
        hat3.SetActive(hat3on);
    }
        if(a == 3)
    {
        hat1on = false;
        hat2on = false;
        hat3on = true;
        hat1.SetActive(hat1on);
        hat2.SetActive(hat2on);
        hat3.SetActive(hat3on);
    }
}
}