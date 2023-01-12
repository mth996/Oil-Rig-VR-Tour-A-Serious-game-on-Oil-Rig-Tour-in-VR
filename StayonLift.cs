using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayonLift : MonoBehaviour
{
   
    public GameObject Player;
    // Start is called before the first frame update
    private void OntriggerEnter (Collision hit)
    { 
        if(hit.gameObject == Player)
        {
            Player.transform.parent = transform ; 
        }
        
    }
    private void OntriggerExit (Collision hit)
    { 
        if(hit.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
    
}
