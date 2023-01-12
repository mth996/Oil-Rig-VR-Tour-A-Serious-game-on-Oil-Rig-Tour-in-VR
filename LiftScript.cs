using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
  
    public ElevatorSystem elevator;
    
    
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            elevator.MoveElevator();
        }
        
    }




    
}
