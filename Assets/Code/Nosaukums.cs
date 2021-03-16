using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nosaukums : MonoBehaviour
{
    string teksts;
    public GameObject Vards;
    public GameObject Sveiki;
    string gads;
    public GameObject Vecums;
    public GameObject vecs;
 public void uzgabatTekstu(){
     teksts=Vards.GetComponent<Text>().text;
     Sveiki.GetComponent<Text>().text="Jūsu vārds ir: "+teksts+" un jūs esat "+gads+" vecs";
     gads=Vecums.GetComponent<Text>().text;
     vecs.GetComponent<Text>().text="Jūsu vārds ir: "+teksts+" un jūs esat "+gads+" vecs";
 }
}