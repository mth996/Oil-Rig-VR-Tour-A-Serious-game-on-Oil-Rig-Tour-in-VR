using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneManager : MonoBehaviour
{
    public GameObject Scene01_Button;
    public GameObject Scene02_Button;
    public GameObject LoadingCanvas;

    public void OnScene01_ButtonClicked()
    {
       StartCoroutine(LoadScene());
       //SceneManager.LoadScene("Scene01");
    }
    
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1.0f);
        LoadingCanvas.SetActive(true);
        StartCoroutine(CompleteLoad());
    }
    IEnumerator CompleteLoad()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("OnshoreOilrig");
    }

    public void OnScene02_ButtonClicked()
    {
        SceneManager.LoadScene("OffShoreOilrig");
    }

}



