using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaleShakerDestination : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider sd)
    {
        if (sd.gameObject.tag == "Player")
        {
            GameManager.Instance.isShaleShakerDestinationVisited = true;
            UIManager.Instance.HasVisitedShleshkr();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
