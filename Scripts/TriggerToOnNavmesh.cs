using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToOnNavmesh : MonoBehaviour
{
    public void OnTriggerEnter(Collider onNav)
    {
        if (onNav.tag == "Player")
        {   
            //StartCoroutine(LiftUp());
            NavmeshManager.Instance.TurnonNavmesh();

        }
    }
}
