using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    
    int scorer = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            scorer++;
            Debug.Log("Bumped time: " + scorer); 
        }  
    }
}
