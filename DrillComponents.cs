using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class DrillComponents : MonoBehaviour
{
    [Header("Ui Panel")]
    public GameObject StartPannel;
    public GameObject StartButton;
    public GameObject UiPanel;
    public GameObject BlowoutPreventerButton;

    [Header("Blowout Preventer Panel")]
    public GameObject BlowoutPreventerPanel;
    public GameObject BlowoutpreventernextButton;

    [Header("Derrick Ui Panels")]
    public GameObject DerrickUiPanel;
    public GameObject IronRoughnecksButton;
    public GameObject TopdriveButton;
    public GameObject TurntableButton;
    public GameObject DerrickButton;
    public GameObject DrillstringButton;
    public GameObject DrillcollarButton;
    public GameObject DrawworksButton;
    public GameObject DerrickUiNextButton;

    [Header("Drill Collar Panel")]
    public GameObject DrillCollarPanel;
    public GameObject DrillCollarbackButton;

    [Header("IronRoughnecksPanel")]
    public GameObject IronRoughnecksPanel;
    public GameObject IronRoughnecksbackButton;

    [Header("DrawworksPanel")]
    public GameObject DrawworksPanel;
    public GameObject DrawworksbackButton;

    [Header("TopdrivePanel")]
    public GameObject TopdrivePanel;
    public GameObject TopdrivebackButton;

    [Header("Turntable Panel")]
    public GameObject TurntablePanel;
    public GameObject TurntablebackButton;

    [Header("Drill String Panel")]
    public GameObject DrillstringPanel;
    public GameObject DrillstringbackButton;


    [Header("Derrick Panel")]
    public GameObject DerrickPanel;
    public GameObject DerrickbackButton;

    [Header("Ui Pannel 2")]
    public GameObject UiPanel2;
    public GameObject MudpumpButton;
    public GameObject ShaleShakersButton;
    public GameObject Ui2PanelNextbutton;

    [Header("Mud Pump Panel")]
    public GameObject MudpumpPanel;
    public GameObject MudpumpbackButton;
    

    [Header("Shale shakers Panel")]
    public GameObject ShaleShakersPanel;
    public GameObject ShaleshakersbackButton;
    
    [Header("Navmesh Destinations")]
    [SerializeField] 
    public Transform blowoutPreventerTransform;
    public Transform guidehub;
    public Transform shaleShakerTransform;
    public Transform elevatorlocationTransform;
    public Transform derrickTransform;
    public NavMeshAgent navMeshAgent;
    public bool isLiftUp;
    public float Duration;
    public GameObject tourCompletePannel;
    public GameObject returnToMainMenuButton;

    //
    
    private void Awake () 
    {
        //navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = guidehub.position;
        //Duration = 7.0f;
    }
    
    
    
    public void Starton()
    {
        //BlowoutPreventerPanel.SetActive(true);
        StartPannel.SetActive(false);
        navMeshAgent.destination = blowoutPreventerTransform.position;
        Debug.Log(navMeshAgent.destination);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);
        
        if (collision.tag == "BPLocation")
        {   
            UiPanel.SetActive(true);
        }
        else if (collision.tag == "SSLocation")
        {   
            UiPanel2.SetActive(true);
            navMeshAgent.destination = shaleShakerTransform.position;
        }
        else if (collision.tag == "ElevatorLocation")
        {   
            //StartCoroutine(LiftUp());
            NavmeshManager.Instance.TurnoffNavmesh();
            navMeshAgent.destination = derrickTransform.position;

        }
         else if (collision.tag == "Collide")
        {   
            
            navMeshAgent.destination = derrickTransform.position;

        }
        else if (collision.tag == "DerrickLocation")
        {   
           DerrickUiPanel.SetActive(true);
           navMeshAgent.destination = derrickTransform.position;
        }
         else if (collision.tag == "GuidehubLocation")
        {   
            UiPanel.SetActive(true);
        }
    }
    
    public IEnumerator LiftUp()
    {
        NavmeshManager.Instance.TurnoffNavmesh();
        yield return new WaitForSeconds(15.0f);
        NavmeshManager.Instance.TurnonNavmesh();
        navMeshAgent.destination = derrickTransform.position;
        isLiftUp = true;
    }


    public void BlowoutPreventeron()
    {
        BlowoutPreventerPanel.SetActive(true);
        navMeshAgent.destination = blowoutPreventerTransform.position;
        UiPanel.SetActive(false);
    }

    public void BlowoutPreventeroff()
    {
        BlowoutPreventerPanel.SetActive(false);
        navMeshAgent.destination = shaleShakerTransform.position;
       
    }
   

    public void DrillCollaron()
    {
        DrillCollarPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void DrillCollaroff()
    {
        DrillCollarPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void DrillStringon()
    {
        DrillstringPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void DrillStringoff()
    {
        DrillstringPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void DrawWorkson()
    {
        DrawworksPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void DrawWorksoff()
    {
        DrawworksPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void Derrickon()
    {
        DerrickPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void Derrickoff()
    {
        DerrickPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void IronRoughneckson()
    {
        IronRoughnecksPanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void IronRoughnecksoff()
    {
        IronRoughnecksPanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void TopDriveon()
    {
        TopdrivePanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void TopDriveoff()
    {
        TopdrivePanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void Turntableon()
    {
        TurntablePanel.SetActive(true);
        DerrickUiPanel.SetActive(false);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void Turntableoff()
    {
        TurntablePanel.SetActive(false);
        DerrickUiPanel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void Ui2on()
    {
        UiPanel2.SetActive(true);
        MudpumpPanel.SetActive(false);
        ShaleShakersPanel.SetActive(false);
        navMeshAgent.destination = shaleShakerTransform.position;
    }

    public void Mudpumpon()
    {
        UiPanel2.SetActive(false);
        MudpumpPanel.SetActive(true);
        ShaleShakersPanel.SetActive(false);
        navMeshAgent.destination = shaleShakerTransform.position;
    }

    public void Shaleshakerson()
    {
        UiPanel2.SetActive(false);
        MudpumpPanel.SetActive(false);
        ShaleShakersPanel.SetActive(true);
        navMeshAgent.destination = shaleShakerTransform.position;
    }

    public void DerrickNext()
    {
        
        DerrickUiPanel.SetActive(false);
        tourCompletePannel.SetActive(true);
        navMeshAgent.destination = derrickTransform.position;
    }

    public void Ui2Next()
    {
        UiPanel2.SetActive(false);
        navMeshAgent.destination = elevatorlocationTransform.position;
    }

    //Button clicked Functions
  
    public void OnStartButtonClicked()
    {
        Starton();
    }

    public void OnBlowoutpreventerButtonClicked()
    {
        BlowoutPreventeron();
    }

    public void OnBlowoutpreventernextButtonClicked()
    {
        BlowoutPreventeroff();
    }

    public void OnDrillcollarButtonClicked()
    {
        DrillCollaron();
    }

    public void OnDrillcollarbackButtonClicked()
    {
        DrillCollaroff();
    }

    public void OnDrillstringButtonClicked()
    {
        DrillStringon();
    }

    public void OnDrillstringbackButtonClicked()
    {
        DrillStringoff();
    }

    public void OnDrawworksButtonClicked()
    {
        DrawWorkson();
    }

    public void OnDrawworksbackButtonClicked()
    {
        DrawWorksoff();
    }

    public void OnDerrickButtonClicked()
    {
        Derrickon();
    }

    public void OnDerrickbackButtonClicked()
    {
        Derrickoff();
    }

    public void OnIronRoughnecksButtonClicked()
    {
        IronRoughneckson();
    }

    public void OnIronRoughnecksbackButtonClicked()
    {
        IronRoughnecksoff();
    }

    public void OnTopdriveButtonClicked()
    {
        TopDriveon();
    }

    public void OnTopdrivebackButtonClicked()
    {
        TopDriveoff();
    }

    public void OnTurntableButtonClicked()
    {
        Turntableon();
    }

    public void OnTurntablebackButtonClicked()
    {
        Turntableoff();
    }

    public void OnMudpumpButtonClicked()
    {
        Mudpumpon();
    }

    public void OnMudpumpbackButtonClicked()
    {
        Ui2on();
    }
    public void OnShaleShakersButtonClicked()
    {
        Shaleshakerson();
    }

    public void OnShaleshakersbackButtonClicked()
    {
        Ui2on();
    }
    

    public void OnUi2NextButtonClicked()
    {
        Ui2Next();
        
    }

    public void OnDerrickUiNextButtonClicked()
    {
        DerrickNext();
    }
    public void OnReturnToMainMenuButtonClicked()
    {
        SceneManager.LoadScene("Lobby");
    }

}


