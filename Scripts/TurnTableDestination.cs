using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTableDestination : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerEnter(Collider tt)
    {
        if (tt.gameObject.tag == "Player")
        {
            GameManager.Instance.isTurnTableDestinationVisited = true;
            UIManager.Instance.HasVisitedTrnTble();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
