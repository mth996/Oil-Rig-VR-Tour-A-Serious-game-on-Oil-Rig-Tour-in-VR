using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotOffShore : MonoBehaviour
{
    [SerializeField]
    public Transform PlayerTransform;
    public Transform QuizTransform;
    public GameObject Componentlist;
    public GameObject Quiz;

    private NavMeshAgent navmeshAgent;
    // Start is called before the first frame update
    private void Awake()
    {
        navmeshAgent = GetComponent<NavMeshAgent>();
        
    }

    private void OnTriggerEnter(Collider quizz)
    {
        Debug.Log(quizz);
        
        if (quizz.tag == "Quiz")
        {   
            Quiz.SetActive(true);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(GameManager.Instance.isTurnTableDestinationVisited == true && GameManager.Instance.isDrawWorksDestinationVisited == true && GameManager.Instance.isBlowOutPreventorDestinationVisited == true && GameManager.Instance.isShaleShakerDestinationVisited == true && GameManager.Instance.isMudPumpDestinationVisited == true)
        {
            Componentlist.SetActive(false);
            navmeshAgent.destination = QuizTransform.position;
        }
        else
        {
            navmeshAgent.destination = PlayerTransform.position;
        }
    
        
          
       
    }
}
