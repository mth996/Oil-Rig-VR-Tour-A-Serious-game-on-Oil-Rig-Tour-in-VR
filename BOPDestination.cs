using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOPDestination : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider bd)
    {
        if (bd.gameObject.tag == "Player")
        {
            GameManager.Instance.isBlowOutPreventorDestinationVisited = true;
            UIManager.Instance.HasVisitedBOP();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
