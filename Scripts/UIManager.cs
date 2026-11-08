using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Singleton
    private static UIManager instance;
    public static UIManager Instance {get { return instance; }}

    /*public TextMeshProUGUI TrnTble;
    public TextMeshProUGUI DrwWrks;
    public TextMeshProUGUI BOP;
    public TextMeshProUGUI Shleshkr;
    public TextMeshProUGUI MudPmp;*/

    public Text TrnTble;
    public Text DrwWrks;
    public Text BOP;
    public Text Shleshkr;
    public Text MudPmp;
    public GameObject levelComplete;


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

    public void HasVisitedTrnTble()
    {
        TrnTble.text = "Turn Table Located";
        TrnTble.color = new Color(0, 128, 0, 1);
    }

    public void HasVisitedDrwWrks()
    {
        DrwWrks.text = "Draw Works Located";
        DrwWrks.color = new Color(0, 128, 0, 1);
    }
    public void HasVisitedBOP()
    {
        BOP.text = "BOP Located";
        BOP.color = new Color(0, 128, 0, 1);
    }

    public void HasVisitedShleshkr()
    {
        Shleshkr.text = "Shale Shaker Located";
        Shleshkr.color = new Color(0, 128, 0, 1);
    }
    public void HasVisitedMudPmp()
    {
        MudPmp.text = "Mud Pump Located";
        MudPmp.color = new Color(0, 128, 0, 1);
    }
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("Lobby");
    }
    
}
