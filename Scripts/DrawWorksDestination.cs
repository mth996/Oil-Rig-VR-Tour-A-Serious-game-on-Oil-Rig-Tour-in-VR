using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWorksDestination : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerEnter(Collider dwd)
    {
        if (dwd.gameObject.tag == "Player")
        {
            GameManager.Instance.isDrawWorksDestinationVisited = true;
            UIManager.Instance.HasVisitedDrwWrks();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
