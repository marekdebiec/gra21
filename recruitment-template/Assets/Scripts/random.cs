using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random : MonoBehaviour
{
    private Text UIText;
    public float randomNumber;
  

    // Start is called before the first frame update
    void Start()
    {
        // returns a random number between 1 and 11
        randomNumber = Random.Range(1, 12);
      
        GetComponent<Text>().text = randomNumber.ToString();
       
    }   
    public void Swap()
    {
        randomNumber = Random.Range(1, 12);
        GetComponent<Text>().text = randomNumber.ToString();
    }
}
