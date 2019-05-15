using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {

    public GameObject[] popUps;
    public int popUpIndex;
    public int tutorialStatus;
    // Update is called once per frame

    private void Start()
    {
        tutorialStatus = PlayerPrefs.GetInt("tutorialStatus");
    }

    void Update () {
        if (tutorialStatus == 0)
        {
            startTutorial();

        }
    }


    public void popUpInc()
    {
        popUpIndex ++;
    }

    public void tutorialDone()
    {
        PlayerPrefs.SetInt("tutorialStatus", 1);
    }

    public void startTutorial()
    {
        if (popUpIndex == 0)
        {
            popUps[popUpIndex].SetActive(true);
        }
        else if (popUpIndex == 1)
        {
            popUps[popUpIndex - 1].SetActive(false);
            popUps[popUpIndex].SetActive(true);

        }
        else if (popUpIndex == 2)
        {
            popUps[popUpIndex - 1].SetActive(false);
            popUps[popUpIndex].SetActive(true);
        }
    }
}
