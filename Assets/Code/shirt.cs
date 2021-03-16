using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shirt : MonoBehaviour
{
    public int a = 0;
    public GameObject right;
    public GameObject left;
    public GameObject shirt1;
    public GameObject shirt2;
    public GameObject shirt3;
    public GameObject shirt4;
    public GameObject shirt5;

    public bool shirt1on;
    public bool shirt2on;
    public bool shirt3on;
    public bool shirt4on;
    public bool shirt5on;


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
        shirt1on = false;
        shirt2on = false;
        shirt3on = false;
        shirt4on = false;
        shirt5on = false;
        shirt1.SetActive(shirt1on);
        shirt2.SetActive(shirt2on);
        shirt3.SetActive(shirt3on);
        shirt4.SetActive(shirt4on);
        shirt5.SetActive(shirt5on);
    }
    if(a == 1)
    {
        shirt1on = true;
        shirt2on = false;
        shirt3on = false;
        shirt4on = false;
        shirt5on = false;
        shirt1.SetActive(shirt1on);
        shirt2.SetActive(shirt2on);
        shirt3.SetActive(shirt3on);
        shirt4.SetActive(shirt4on);
        shirt5.SetActive(shirt5on);
    }
        if(a == 2)
    {
        shirt1on = false;
        shirt2on = true;
        shirt3on = false;
        shirt4on = false;
        shirt5on = false;
        shirt1.SetActive(shirt1on);
        shirt2.SetActive(shirt2on);
        shirt3.SetActive(shirt3on);
        shirt4.SetActive(shirt4on);
        shirt5.SetActive(shirt5on);
    }
        if(a == 3)
    {
        shirt1on = false;
        shirt2on = false;
        shirt3on = true;
        shirt4on = false;
        shirt5on = false;
        shirt1.SetActive(shirt1on);
        shirt2.SetActive(shirt2on);
        shirt3.SetActive(shirt3on);
        shirt4.SetActive(shirt4on);
        shirt5.SetActive(shirt5on);
    }
        if(a == 4)
    {
        shirt1on = false;
        shirt2on = false;
        shirt3on = false;
        shirt4on = true;
        shirt5on = false;
        shirt1.SetActive(shirt1on);
        shirt2.SetActive(shirt2on);
        shirt3.SetActive(shirt3on);
        shirt4.SetActive(shirt4on);
        shirt5.SetActive(shirt5on);
    }
        if(a == 5)
    {
        shirt1on = false;
        shirt2on = false;
        shirt3on = false;
        shirt4on = false;
        shirt5on = true;
        shirt1.SetActive(shirt1on);
        shirt2.SetActive(shirt2on);
        shirt3.SetActive(shirt3on);
        shirt4.SetActive(shirt4on);
        shirt5.SetActive(shirt5on);
    }
}
}