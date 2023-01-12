using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScriptOffShore : MonoBehaviour
{
    // Start is called before the first frame update
  public ElevatorSystemOffShore  elevator;
    
    
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Robot")
        {
            elevator.MoveElevator();
        }
        
    }
}
