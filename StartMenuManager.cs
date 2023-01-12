using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{

    [Header("MainMenu Panel")]
    public GameObject MainMenuPanel;
    public GameObject StartButton;
    public GameObject OptionsButton;
    public GameObject CreditsButton;
    public GameObject QuitButton;

    [Header("Options Pannel")]
    public GameObject OptionsPanel;
    public GameObject ControlButton; 
    public GameObject OptionBackButton; 

    [Header("Credits Panel")]
    public GameObject CreditsPanel;

    [Header("KeyBindings Panel")]
    public GameObject KeyBindingsPanel;
    public GameObject MainMenuButton;
    public GameObject ControlsBackButton;


    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("HandsInteractionTrainScene");
    }

    public void OnOptionsButtonClicked()
    {
        GameObject.Find("OptionsPanel").SetActive(true);
    }

    public void OnOptionBackButtonClicked()
    {
        GameObject.Find("OptionsPanel").SetActive(false);
    }

    public void OnCreditsButtonClicked()
    {
        GameObject.Find("CreditsPanel").SetActive(true);
    }
    public void OnControlButtonClicked()
    {
        GameObject.Find("KeyBindingsPanel").SetActive(true);
    }

    public void OnControlsBackButtonClicked()
    {
        GameObject.Find("KeyBindingsPanel").SetActive(false);
    }

    public void OnMainMenuButtonClicked()
    {
        GameObject.Find("KeyBindingsPanel").SetActive(false);
        GameObject.Find("OptionsPanel").SetActive(false);
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }
}
