using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshManager : MonoBehaviour
{
    // Start is called before the first frame update
      // Singleton
    private static NavmeshManager instance;
    public static NavmeshManager Instance {get { return instance; }}


    
    
    public NavMeshAgent robot;

    private void Awake()
    {
        // Singleton
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);

        } 
        else 
        {
            instance = this;
        }
    }
    
    public void TurnonNavmesh()
    {
        robot.GetComponent<NavMeshAgent>().enabled = true;
    }
     
    public void TurnoffNavmesh()
    {
        robot.GetComponent<NavMeshAgent>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
