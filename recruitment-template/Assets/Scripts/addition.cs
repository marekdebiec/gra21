using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addition : MonoBehaviour
{
    public int overallResult = 0;
    public float clickResult = 0;
    public GameObject[] titles;
    public GameObject result;
    public GameObject[] textes;
    public GameObject retry;

    // Start is called before the first frame update
    void Start()
    {
        result.GetComponent < Text >().text = "0";
    }
    //restart the game
    public void Shuffle ()
    {
        for (int z = 0; z < textes.Length; z++)
        {
            textes[z].SetActive(true);
        }
        overallResult = 0;
        retry.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        result.GetComponent<Text>().text = overallResult.ToString();
        if (clickResult == 21)
        {

            overallResult += 21;
            clickResult = 0;
            
            for (int y =0; y < titles.Length; y++)
            {
                if (titles[y].GetComponent<tile>().select2 == true) 
                { 
               
                    titles[y].GetComponentInChildren<random>().Swap();
                }
            }
           
            
          
            
            for (int i=0; i < titles.Length ;  i++) {
                titles[i].GetComponent<tile>().select2 = false;
            }
            
            
        }
        if (clickResult > 21 )
        {
            overallResult += (int )(clickResult / 2);
            clickResult = 0;

            
            for (int y = 0; y < titles.Length; y++)
            {
                if (titles[y].GetComponent<tile>().select2 == true)
                {

                    titles[y].GetComponentInChildren<random>().Swap();
                }
            }


            int i;
            for (i = 0; i < titles.Length; i++)
            {
                titles[i].GetComponent<tile>().select2 = false;
            }
            
        }
       if (overallResult >= 60)
        {
                    
            retry.GetComponent<Text>().text = "Retry";
          
            for (int z = 0; z < textes.Length; z++)
            {
                textes[z].SetActive(false);
            }
        }
    }
    
}
