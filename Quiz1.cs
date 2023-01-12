using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz1 : MonoBehaviour
{
    [Header("Start Quiz Panel")]
    public GameObject StartQuizPanel;
    public GameObject StartQuizButton;

    [Header("Quiz 1 Panel")]
    public GameObject Quiz1Panel;
    public GameObject Blowoutpreventer1Button;
    public GameObject IronRoughNecks2Button;
    public GameObject BlowupPreventer3Button ;
    public GameObject TopDrive4Button;
    

    [Header("Quiz 1 Correct Answer Panel")]
    public GameObject Quiz1CorrectAnswerPanel;
    public GameObject QuizCorrectBackButton;

    [Header("Quiz 1 Wrong Answer Panel")]
    public GameObject Quiz1WrongAnswerPanel;
    public GameObject QuizwrongBackButton;

    [Header("Quiz 2 Panel")]
    public GameObject Quiz2Panel;
    public GameObject Blowoutpreventer2Button;
    public GameObject IronRoughNecks1Button;
    public GameObject BlowupPreventer4Button;
    public GameObject TopDrive3Button;


    [Header("Quiz 2 Correct Answer Panel")]
    public GameObject Quiz2CorrectAnswerPanel;
    public GameObject Quiz2CorrectNextButton;

    [Header("Quiz 2 Wrong Answer Panel")]
    public GameObject Quiz2WrongAnswerPanel;
    public GameObject Quiz2wrongNextButton;

    [Header("Quiz 3 Panel")]
    public GameObject Quiz3Panel;
    public GameObject Blowoutpreventer3Button;
    public GameObject IronRoughNecks4Button;
    

    [Header("Quiz 3 Correct Answer Panel")]
    public GameObject Quiz3CorrectAnswerPanel;
    public GameObject Quiz3CorrectNextButton;

    [Header("Quiz 3 Wrong Answer Panel")]
    public GameObject Quiz3WrongAnswerPanel;
    public GameObject Quiz3wrongNextButton;

    [Header("Quiz 4 Panel")]
    public GameObject Quiz4Panel;
    public GameObject Blowoutpreventer4Button;
    public GameObject IronRoughNecks3Button;
    public GameObject BlowupPreventer1Button;
    public GameObject TopDrive2Button;


    [Header("Quiz 4 Correct Answer Panel")]
    public GameObject Quiz4CorrectAnswerPanel;
    public GameObject Quiz4CorrectNextButton;

    [Header("Quiz 4 Wrong Answer Panel")]
    public GameObject Quiz4WrongAnswerPanel;
    public GameObject Quiz4wrongNextButton;

    [Header("Quiz 5 Panel")]
    public GameObject Quiz5Panel;
    public GameObject Blowoutpreventer5Button;
    public GameObject IronRoughNecks6Button;
    public GameObject BlowupPreventer7Button;
    public GameObject TopDrive8Button;


    [Header("Quiz 5 Correct Answer Panel")]
    public GameObject Quiz5CorrectAnswerPanel;
    public GameObject Quiz5CorrectNextButton;

    [Header("Quiz 5 Wrong Answer Panel")]
    public GameObject Quiz5WrongAnswerPanel;
    public GameObject Quiz5wrongNextButton;

    [Header("Quiz 6 Panel")]
    public GameObject Quiz6Panel;
    public GameObject Blowoutpreventer6Button;
    public GameObject IronRoughNecks7Button;
    public GameObject BlowupPreventer8Button;
 
    [Header("Quiz 6 Correct Answer Panel")]
    public GameObject Quiz6CorrectAnswerPanel;
    public GameObject Quiz6CorrectNextButton;

    [Header("Quiz 6 Wrong Answer Panel")]
    public GameObject Quiz6WrongAnswerPanel;
    public GameObject Quiz6wrongNextButton;

    [Header("Quiz 7 Panel")]
    public GameObject Quiz7Panel;
    public GameObject Blowoutpreventer7Button;
    public GameObject IronRoughNecks8Button;
    public GameObject BlowupPreventer5Button;
    public GameObject TopDrive6Button;


    [Header("Quiz 7 Correct Answer Panel")]
    public GameObject Quiz7CorrectAnswerPanel;
    public GameObject Quiz7CorrectNextButton;

    [Header("Quiz 7 Wrong Answer Panel")]
    public GameObject Quiz7WrongAnswerPanel;
    public GameObject Quiz7wrongNextButton;

    [Header("Quiz 8 Panel")]
    public GameObject Quiz8Panel;
    public GameObject Blowoutpreventer8Button;
    public GameObject IronRoughNecks5Button;
    public GameObject BlowupPreventer6Button;
 

    [Header("Quiz 8 Correct Answer Panel")]
    public GameObject Quiz8CorrectAnswerPanel;
    public GameObject Quiz8CorrectNextButton;

    [Header("Quiz 8 Wrong Answer Panel")]
    public GameObject Quiz8WrongAnswerPanel;
    public GameObject Quiz8wrongNextButton;

    public void StartQuizon()
    {
        Quiz1Panel.SetActive(true);
        StartQuizPanel.SetActive(false);
        Quiz1WrongAnswerPanel.SetActive(false);
    }

    public void StartQuizoff()
    {
        Quiz1Panel.SetActive(false);
        StartQuizPanel.SetActive(true);
        Quiz1WrongAnswerPanel.SetActive(false);
    }
    public void Quiz1on()
    {
        Quiz1Panel.SetActive(true);
        Quiz1CorrectAnswerPanel.SetActive(false);
        Quiz1WrongAnswerPanel.SetActive(false);
    }


    public void Quiz1off()
    {
        Quiz1Panel.SetActive(false);
        Quiz1CorrectAnswerPanel.SetActive(false);
        Quiz1WrongAnswerPanel.SetActive(false);
    }

    public void Quiz1CorrectAnsweron()
    {
        Quiz1Panel.SetActive(false);
        Quiz1CorrectAnswerPanel.SetActive(true);
        Quiz1WrongAnswerPanel.SetActive(false);
    }

    public void Quiz1CorrectAnsweroff()
    {
        Quiz2Panel.SetActive(true); ;
        Quiz1CorrectAnswerPanel.SetActive(false);
        Quiz1WrongAnswerPanel.SetActive(false);
    }

    public void Quiz1WrongAnsweron()
    {
        Quiz1Panel.SetActive(false);
        Quiz1CorrectAnswerPanel.SetActive(false);
        Quiz1WrongAnswerPanel.SetActive(true);
    }

    public void Quiz1WrongAnsweoff()
    {
        Quiz2Panel.SetActive(true);
        Quiz1CorrectAnswerPanel.SetActive(false);
        Quiz1WrongAnswerPanel.SetActive(false);
    }

    public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }

    public void OnBlowoutpreventer1ButtonClicked()
    {
        Quiz1CorrectAnsweron();
    }

    public void OnIronRoughNecks2ButtonClicked()
    {
        Quiz1WrongAnsweron();
    }

    public void OnBlowupPreventer3ButtonClicked()
    {
        Quiz1WrongAnsweron();
    }

    public void OnTopDrive4ButtonClicked()
    {
        Quiz1WrongAnsweron();
    }

    public void OnQuizCorrectBackButtonClicked()
    {
        Quiz1CorrectAnsweroff();
    }

    public void OnQuizwrongBackButtonClicked()
    {
        Quiz1WrongAnsweoff();
    }

    //new//

    public void Quiz2on()
    {
        Quiz2Panel.SetActive(true);
        Quiz2CorrectAnswerPanel.SetActive(false);
        Quiz2WrongAnswerPanel.SetActive(false);
    }


    public void Quiz2off()
    {
        Quiz2Panel.SetActive(false);
        Quiz2CorrectAnswerPanel.SetActive(false);
        Quiz2WrongAnswerPanel.SetActive(false);
    }

    public void Quiz2CorrectAnsweron()
    {
        Quiz2Panel.SetActive(false);
        Quiz2CorrectAnswerPanel.SetActive(true);
        Quiz2WrongAnswerPanel.SetActive(false);
    }

    public void Quiz2CorrectAnsweroff()
    {
        Quiz3Panel.SetActive(true); ;
        Quiz2CorrectAnswerPanel.SetActive(false);
        Quiz2WrongAnswerPanel.SetActive(false);
    }

    public void Quiz2WrongAnsweron()
    {
        Quiz2Panel.SetActive(false);
        Quiz2CorrectAnswerPanel.SetActive(false);
        Quiz2WrongAnswerPanel.SetActive(true);
    }

    public void Quiz2WrongAnsweoff()
    {
        Quiz3Panel.SetActive(true);
        Quiz2CorrectAnswerPanel.SetActive(false);
        Quiz2WrongAnswerPanel.SetActive(false);
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer2ButtonClicked()
    {
        Quiz2CorrectAnsweron();
    }

    public void OnIronRoughNecks1ButtonClicked()
    {
        Quiz2WrongAnsweron();
    }

    public void OnBlowupPreventer4ButtonClicked()
    {
        Quiz2WrongAnsweron();
    }

    public void OnTopDrive3ButtonClicked()
    {
        Quiz2WrongAnsweron();
    }

    public void OnQuiz2CorrectNextButtonClicked()
    {
        Quiz2CorrectAnsweroff();
    }

    public void OnQuiz2wrongNextButtonClicked()
    {
        Quiz2WrongAnsweoff();
    }
    //new//
    public void Quiz3on()
    {
        Quiz3Panel.SetActive(true);
        Quiz3CorrectAnswerPanel.SetActive(false);
        Quiz3WrongAnswerPanel.SetActive(false);
    }


    public void Quiz3off()
    {
        Quiz3Panel.SetActive(false);
        Quiz3CorrectAnswerPanel.SetActive(false);
        Quiz3WrongAnswerPanel.SetActive(false);
    }

    public void Quiz3CorrectAnsweron()
    {
        Quiz3Panel.SetActive(false);
        Quiz3CorrectAnswerPanel.SetActive(true);
        Quiz3WrongAnswerPanel.SetActive(false);
    }

    public void Quiz3CorrectAnsweroff()
    {
        Quiz4Panel.SetActive(true); ;
        Quiz3CorrectAnswerPanel.SetActive(false);
        Quiz3WrongAnswerPanel.SetActive(false);
    }

    public void Quiz3WrongAnsweron()
    {
        Quiz3Panel.SetActive(false);
        Quiz3CorrectAnswerPanel.SetActive(false);
        Quiz3WrongAnswerPanel.SetActive(true);
    }

    public void Quiz3WrongAnsweoff()
    {
        Quiz4Panel.SetActive(true);
        Quiz3CorrectAnswerPanel.SetActive(false);
        Quiz3WrongAnswerPanel.SetActive(false);
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer3ButtonClicked()
    {
        Quiz3CorrectAnsweron();
    }

    public void OnIronRoughNecks4ButtonClicked()
    {
        Quiz3WrongAnsweron();
    }

    public void OnQuiz3CorrectNextButtonClicked()
    {
        Quiz3CorrectAnsweroff();
    }

    public void OnQuiz3wrongNextButtonClicked()
    {
        Quiz3WrongAnsweoff();
    }


    //new//
    public void Quiz4on()
    {
        Quiz4Panel.SetActive(true);
        Quiz4CorrectAnswerPanel.SetActive(false);
        Quiz4WrongAnswerPanel.SetActive(false);
    }


    public void Quiz4off()
    {
        Quiz4Panel.SetActive(false);
        Quiz4CorrectAnswerPanel.SetActive(false);
        Quiz4WrongAnswerPanel.SetActive(false);
    }

    public void Quiz4CorrectAnsweron()
    {
        Quiz4Panel.SetActive(false);
        Quiz4CorrectAnswerPanel.SetActive(true);
        Quiz4WrongAnswerPanel.SetActive(false);
    }

    public void Quiz4CorrectAnsweroff()
    {
        Quiz5Panel.SetActive(true); ;
        Quiz4CorrectAnswerPanel.SetActive(false);
        Quiz4WrongAnswerPanel.SetActive(false);
    }

    public void Quiz4WrongAnsweron()
    {
        Quiz4Panel.SetActive(false);
        Quiz4CorrectAnswerPanel.SetActive(false);
        Quiz4WrongAnswerPanel.SetActive(true);
    }

    public void Quiz4WrongAnsweoff()
    {
        Quiz5Panel.SetActive(true);
        Quiz4CorrectAnswerPanel.SetActive(false);
        Quiz4WrongAnswerPanel.SetActive(false);
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer4ButtonClicked()
    {
        Quiz4CorrectAnsweron();
    }

    public void OnIronRoughNecks3ButtonClicked()
    {
        Quiz4WrongAnsweron();
    }

    public void OnBlowupPreventer1ButtonClicked()
    {
        Quiz4WrongAnsweron();
    }

    public void OnTopDrive2ButtonClicked()
    {
        Quiz4WrongAnsweron();
    }

    public void OnQuiz4CorrectNextButtonClicked()
    {
        Quiz4CorrectAnsweroff();
    }

    public void OnQuiz4wrongNextButtonClicked()
    {
        Quiz4WrongAnsweoff();
    }
    //New//
    public void Quiz5on()
    {
        Quiz5Panel.SetActive(true);
        Quiz5CorrectAnswerPanel.SetActive(false);
        Quiz5WrongAnswerPanel.SetActive(false);
    }


    public void Quiz5off()
    {
        Quiz5Panel.SetActive(false);
        Quiz5CorrectAnswerPanel.SetActive(false);
        Quiz5WrongAnswerPanel.SetActive(false);
    }

    public void Quiz5CorrectAnsweron()
    {
        Quiz5Panel.SetActive(false);
        Quiz5CorrectAnswerPanel.SetActive(true);
        Quiz5WrongAnswerPanel.SetActive(false);
    }

    public void Quiz5CorrectAnsweroff()
    {
        Quiz6Panel.SetActive(true); ;
        Quiz5CorrectAnswerPanel.SetActive(false);
        Quiz5WrongAnswerPanel.SetActive(false);
    }

    public void Quiz5WrongAnsweron()
    {
        Quiz5Panel.SetActive(false);
        Quiz5CorrectAnswerPanel.SetActive(false);
        Quiz5WrongAnswerPanel.SetActive(true);
    }

    public void Quiz5WrongAnsweoff()
    {
        Quiz6Panel.SetActive(true);
        Quiz5CorrectAnswerPanel.SetActive(false);
        Quiz5WrongAnswerPanel.SetActive(false);
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer5ButtonClicked()
    {
        Quiz5CorrectAnsweron();
    }

    public void OnIronRoughNecks6ButtonClicked()
    {
        Quiz5WrongAnsweron();
    }

    public void OnBlowupPreventer7ButtonClicked()
    {
        Quiz5WrongAnsweron();
    }

    public void OnTopDrive8ButtonClicked()
    {
        Quiz5WrongAnsweron();
    }

    public void OnQuiz5CorrectNextButtonClicked()
    {
        Quiz5CorrectAnsweroff();
    }

    public void OnQuiz5wrongNextButtonClicked()
    {
        Quiz5WrongAnsweoff();
    }
    //new//
    public void Quiz6on()
    {
        Quiz6Panel.SetActive(true);
        Quiz6CorrectAnswerPanel.SetActive(false);
        Quiz6WrongAnswerPanel.SetActive(false);
    }


    public void Quiz6off()
    {
        Quiz6Panel.SetActive(false);
        Quiz6CorrectAnswerPanel.SetActive(false);
        Quiz6WrongAnswerPanel.SetActive(false);
    }

    public void Quiz6CorrectAnsweron()
    {
        Quiz6Panel.SetActive(false);
        Quiz6CorrectAnswerPanel.SetActive(true);
        Quiz6WrongAnswerPanel.SetActive(false);
    }

    public void Quiz6CorrectAnsweroff()
    {
        Quiz7Panel.SetActive(true); ;
        Quiz6CorrectAnswerPanel.SetActive(false);
        Quiz6WrongAnswerPanel.SetActive(false);
    }

    public void Quiz6WrongAnsweron()
    {
        Quiz6Panel.SetActive(false);
        Quiz6CorrectAnswerPanel.SetActive(false);
        Quiz6WrongAnswerPanel.SetActive(true);
    }

    public void Quiz6WrongAnsweoff()
    {
        Quiz7Panel.SetActive(true);
        Quiz6CorrectAnswerPanel.SetActive(false);
        Quiz6WrongAnswerPanel.SetActive(false);
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer6ButtonClicked()
    {
        Quiz6CorrectAnsweron();
    }

    public void OnIronRoughNecks7ButtonClicked()
    {
        Quiz6WrongAnsweron();
    }

    public void OnBlowupPreventer8ButtonClicked()
    {
        Quiz6WrongAnsweron();
    }


    public void OnQuiz6CorrectNextButtonClicked()
    {
        Quiz6CorrectAnsweroff();
    }

    public void OnQuiz6wrongNextButtonClicked()
    {
        Quiz6WrongAnsweoff();
    }


    //new//
    public void Quiz7on()
    {
        Quiz7Panel.SetActive(true);
        Quiz7CorrectAnswerPanel.SetActive(false);
        Quiz7WrongAnswerPanel.SetActive(false);
    }


    public void Quiz7off()
    {
        Quiz7Panel.SetActive(false);
        Quiz7CorrectAnswerPanel.SetActive(false);
        Quiz7WrongAnswerPanel.SetActive(false);
    }

    public void Quiz7CorrectAnsweron()
    {
        Quiz7Panel.SetActive(false);
        Quiz7CorrectAnswerPanel.SetActive(true);
        Quiz7WrongAnswerPanel.SetActive(false);
    }

    public void Quiz7CorrectAnsweroff()
    {
        Quiz8Panel.SetActive(true); ;
        Quiz7CorrectAnswerPanel.SetActive(false);
        Quiz7WrongAnswerPanel.SetActive(false);
    }

    public void Quiz7WrongAnsweron()
    {
        Quiz7Panel.SetActive(false);
        Quiz7CorrectAnswerPanel.SetActive(false);
        Quiz7WrongAnswerPanel.SetActive(true);
    }

    public void Quiz7WrongAnsweoff()
    {
        Quiz8Panel.SetActive(true);
        Quiz7CorrectAnswerPanel.SetActive(false);
        Quiz7WrongAnswerPanel.SetActive(false);
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer7ButtonClicked()
    {
        Quiz7CorrectAnsweron();
    }

    public void OnIronRoughNecks8ButtonClicked()
    {
        Quiz7WrongAnsweron();
    }

    public void OnBlowupPreventer5ButtonClicked()
    {
        Quiz7WrongAnsweron();
    }

    public void OnTopDrive6ButtonClicked()
    {
        Quiz7WrongAnsweron();
    }

    public void OnQuiz7CorrectNextButtonClicked()
    {
        Quiz7CorrectAnsweroff();
    }

    public void OnQuiz7wrongNextButtonClicked()
    {
        Quiz7WrongAnsweoff();
    }

    //new//
    public void Quiz8on()
    {
        Quiz8Panel.SetActive(true);
        Quiz8CorrectAnswerPanel.SetActive(false);
        Quiz8WrongAnswerPanel.SetActive(false);
    }


    public void Quiz8off()
    {
        Quiz8Panel.SetActive(false);
        Quiz8CorrectAnswerPanel.SetActive(false);
        Quiz8WrongAnswerPanel.SetActive(false);
    }

    public void Quiz8CorrectAnsweron()
    {
        Quiz8Panel.SetActive(false);
        Quiz8CorrectAnswerPanel.SetActive(true);
        Quiz8WrongAnswerPanel.SetActive(false);
    }

    public void Quiz8CorrectAnsweroff()
    {
        StartQuizPanel.SetActive(false); ;
        Quiz8CorrectAnswerPanel.SetActive(false);
        Quiz8WrongAnswerPanel.SetActive(false);
        GameManager.Instance.isQuizCompleted = true;
    }

    public void Quiz8WrongAnsweron()
    {
        Quiz8Panel.SetActive(false);
        Quiz8CorrectAnswerPanel.SetActive(false);
        Quiz8WrongAnswerPanel.SetActive(true);
    }

    public void Quiz8WrongAnsweoff()
    {
        StartQuizPanel.SetActive(false);
        Quiz8CorrectAnswerPanel.SetActive(false);
        Quiz8WrongAnswerPanel.SetActive(false);
        GameManager.Instance.isQuizCompleted = true;
    }

    /*public void OnStartQuizButtonClicked()
    {
        StartQuizon();
    }*/

    public void OnBlowoutpreventer8ButtonClicked()
    {
        Quiz8CorrectAnsweron();
    }

    public void OnIronRoughNecks5ButtonClicked()
    {
        Quiz8WrongAnsweron();
    }

    public void OnBlowupPreventer6ButtonClicked()
    {
        Quiz8WrongAnsweron();
    }

    
    public void OnQuiz8CorrectNextButtonClicked()
    {
        Quiz8CorrectAnsweroff();
    }

    public void OnQuiz8wrongNextButtonClicked()
    {
        Quiz8WrongAnsweoff();
    }

}
