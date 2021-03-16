using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoes : MonoBehaviour
{
    public int a = 0;
    public GameObject right;
    public GameObject left;
    public GameObject shoes1;
    public GameObject shoes2;
    public GameObject shoes3;

    public bool shoes1on;
    public bool shoes2on;
    public bool shoes3on;


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
        shoes1on = false;
        shoes2on = false;
        shoes3on = false;
        shoes1.SetActive(shoes1on);
        shoes2.SetActive(shoes2on);
        shoes3.SetActive(shoes3on);
    }
        if(a == 1)
    {
        shoes1on = true;
        shoes2on = false;
        shoes3on = false;
        shoes1.SetActive(shoes1on);
        shoes2.SetActive(shoes2on);
        shoes3.SetActive(shoes3on);
    }
        if(a == 2)
    {
        shoes1on = false;
        shoes2on = true;
        shoes3on = false;
        shoes1.SetActive(shoes1on);
        shoes2.SetActive(shoes2on);
        shoes3.SetActive(shoes3on);
    }
        if(a == 3)
    {
        shoes1on = false;
        shoes2on = false;
        shoes3on = true;
        shoes1.SetActive(shoes1on);
        shoes2.SetActive(shoes2on);
        shoes3.SetActive(shoes3on);
    }
}
}