using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pants : MonoBehaviour
{
    public int a = 0;
    public GameObject right;
    public GameObject left;
    public GameObject pants1;
    public GameObject pants2;
    public GameObject pants3;

    public bool pants1on;
    public bool pants2on;
    public bool pants3on;


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
        pants1on = false;
        pants2on = false;
        pants3on = false;
        pants1.SetActive(pants1on);
        pants2.SetActive(pants2on);
        pants3.SetActive(pants3on);
    }
        if(a == 1)
    {
        pants1on = true;
        pants2on = false;
        pants3on = false;
        pants1.SetActive(pants1on);
        pants2.SetActive(pants2on);
        pants3.SetActive(pants3on);
    }
        if(a == 2)
    {
        pants1on = false;
        pants2on = true;
        pants3on = false;
        pants1.SetActive(pants1on);
        pants2.SetActive(pants2on);
        pants3.SetActive(pants3on);
    }
        if(a == 3)
    {
        pants1on = false;
        pants2on = false;
        pants3on = true;
        pants1.SetActive(pants1on);
        pants2.SetActive(pants2on);
        pants3.SetActive(pants3on);
    }
}
}