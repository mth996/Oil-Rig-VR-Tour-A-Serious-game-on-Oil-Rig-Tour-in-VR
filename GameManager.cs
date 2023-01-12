using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     // Singleton
    private static GameManager instance;
    public static GameManager Instance {get { return instance; }}

    public bool isTurnTableDestinationVisited;
    public bool isDrawWorksDestinationVisited;
    public bool isBlowOutPreventorDestinationVisited;
    public bool isShaleShakerDestinationVisited;
    public bool isMudPumpDestinationVisited;
    public bool isQuizCompleted;
    public GameObject levelCompletePanel;
    public GameObject objectivesPanel;
    public GameObject ExitToMainMenuButton;


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

    private void Update()
    {
        // Timer;
        if(isTurnTableDestinationVisited == true && isDrawWorksDestinationVisited == true && isBlowOutPreventorDestinationVisited == true && isShaleShakerDestinationVisited == true && isMudPumpDestinationVisited == true && isQuizCompleted == true)
        {
            HasCompletedLevel();
        }
    }

    public void HasCompletedLevel()
    {
        levelCompletePanel.SetActive(true);
        objectivesPanel.SetActive(false);
    }
    private void CheckCompleteOnTime()
    {
        Debug.Log("Player visited all places.");
    }
    public void ExitToMainMenuButtonClicked()
    {
        UIManager.Instance.ExitToMainMenu();
    }
}
