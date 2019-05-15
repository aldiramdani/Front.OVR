using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour {
    SceneController1 sc1 = new SceneController1();
    Scene m_sceneName;
    public void ChangeScene(string sceneName)
    {
        sc1.resetScores();
        SceneManager.LoadScene(sceneName);
    }

    public void setLastScene()
    {
        m_sceneName = SceneManager.GetActiveScene();
        PlayerPrefs.SetString("lastScene", m_sceneName.name);
    }
    
}
