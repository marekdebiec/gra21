using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tile : MonoBehaviour
{
    public bool select2 = false;
    public float numerous;
    public GameObject objective;
    public Color kolorek2 = Color.red;
    

    // Update is called once per frame
    void Update()
    {
        GameObject obj;
        obj = this.gameObject.transform.GetChild(0).gameObject;
        random Liczba = GetComponentInChildren<random>();
        if (obj.activeSelf) {
            numerous = Liczba.randomNumber;
        }
        if (!select2 && obj.activeSelf)
        {
            GetComponentInChildren<Text>().color = Color.black;
        }
        
    }
    public void DodajDoWynikOgolny ()
    {
        if (!select2)
        {
            
            GetComponentInChildren<Text>().color = kolorek2;
            select2 = true;
            objective = GameObject.Find("scores");
            addition dodawanie2 = objective.GetComponent<addition>();
            dodawanie2.clickResult += numerous;
        }
       else 
        {
            GetComponentInChildren<Text>().color = Color.black;
            select2 = false;
            objective = GameObject.Find("scores");
            addition dodawanie2 = objective.GetComponent<addition>();
            dodawanie2.clickResult -= numerous;
        }
    }
}
