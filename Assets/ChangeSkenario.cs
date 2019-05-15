using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
public class ChangeSkenario : MonoBehaviour {
    private VideoPlayer videoPlayer;
    string hasilSpeech="";
    DateTime dateTime = DateTime.Now;
    public Button btn_startSpeak;
    public Button btn_insert;
    public string skenarioGanti;
    public string skenarioTujuan;
    Scene m_sceneName;
    public static int nilaiS=0;
    string currentScene;
    public GameObject imgCheckmark,imgCheckmark1, imgCheckmark2, imgCheckmark3, 
        imgCheckmark4, imgCheckmark5, imgCheckmark6, imgCheckmark7, imgCheckmark8, 
        imgCheckmark9;

    private void Start()
    {
        todo();
        btn_startSpeak.onClick.AddListener(mulaiSpeech);     
    }

    private void Update()
    {
        gantiSkenario();
    }
    
    public void mulaiSpeech()
    {
        SpeakNow.startSpeech(LanguageUtil.INDONESIAN);
        btn_startSpeak.GetComponent<Image>().color = Color.green;
    }

    public void gantiSkenario()
    {
        hasilSpeech = SpeakNow.speechResult();
        SceneController1 s1 = new SceneController1();
        s1.sceneControl(hasilSpeech,skenarioGanti,skenarioTujuan);
    }

 
    public void insertData()
    {
        var ds = new DataService("tempDB.db");
        ds.CreateScore(PlayerPrefs.GetInt("nilai"), "Reservasi", dateTime.ToString("yyyy-MM-dd hh:mm:ss"));
    }

    public void InsertDataChecin()
    {
        var ds = new DataService("tempDB.db");
        ds.CreateScore(PlayerPrefs.GetInt("nilai"), "Check-In", dateTime.ToString("yyyy-MM-dd hh:mm:ss"));

    }

    public void InsertDataCheckOut()
    {
        var ds = new DataService("tempDB.db");
        ds.CreateScore(PlayerPrefs.GetInt("nilai"), "CheckOut", dateTime.ToString("yyyy-MM-dd hh:mm:ss"));
    }

    public void stopSpeech()
    {
        SpeakNow.reset();
    }

    public void todo()
    {
        if (PlayerPrefs.GetInt("todo1") != 1)
        {
            imgCheckmark.SetActive(false);
        }
        else
        {
            imgCheckmark.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo2") != 1)
        {
            imgCheckmark1.SetActive(false);
        }
        else
        {
            imgCheckmark1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo3") != 1)
        {
            imgCheckmark2.SetActive(false);
        }
        else
        {
            imgCheckmark2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo4") != 1)
        {
            imgCheckmark3.SetActive(false);
        }
        else
        {
            imgCheckmark3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo5") != 1)
        {
            imgCheckmark4.SetActive(false);
        }
        else
        {
            imgCheckmark4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo6") != 1)
        {
            imgCheckmark5.SetActive(false);
        }
        else
        {
            imgCheckmark5.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo7") != 1)
        {
            imgCheckmark6.SetActive(false);
        }
        else
        {
            imgCheckmark6.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo8") != 1)
        {
            imgCheckmark7.SetActive(false);
        }
        else
        {
            imgCheckmark7.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo9") != 1)
        {
            imgCheckmark8.SetActive(false);
        }
        else
        {
            imgCheckmark8.SetActive(true);
        }
        if (PlayerPrefs.GetInt("todo10") != 1)
        {
            imgCheckmark9.SetActive(false);
        }
        else
        {
            imgCheckmark9.SetActive(true);
        }
    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        throw new NotImplementedException();
    }
    
}
