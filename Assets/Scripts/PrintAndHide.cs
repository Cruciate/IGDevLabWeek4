using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject gameObject;
    int i = 3;
    public Renderer rend;
    public int randomint;
    

    void Start()
    {
        randomint = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
        i++;
        Debug.Log(gameObject.name + ":" + i.ToString());

        if((gameObject.tag == "Red") && (i == 100)){
            gameObject.SetActive(false);
        }


        
        if((gameObject.tag == "Blue") && (i == randomint)){
            rend.enabled = false;
            
        }
    }
}
