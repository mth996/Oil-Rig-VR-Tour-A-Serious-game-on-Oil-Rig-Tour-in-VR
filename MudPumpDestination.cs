using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudPumpDestination : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerEnter(Collider mpd)
    {
        if (mpd.gameObject.tag == "Player")
        {
            GameManager.Instance.isMudPumpDestinationVisited = true;
            UIManager.Instance.HasVisitedMudPmp();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
