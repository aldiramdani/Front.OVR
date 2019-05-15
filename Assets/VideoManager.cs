using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VideoManager : MonoBehaviour {

    public Image imageStatus;
    public float totalTime = 3;
    public float GvrTimer;
    private VideoPlayer videoPlayer;
    bool statusPlayVideo;
    Button btn_play;
    Scene m_sceneName;
    string currentScene;
    Boolean statusMad = true;
    public double time;
    public double currentTime;
    public GameObject gOCanvas;
    bool statusHide = false;

     void Start()
    {

        time = gameObject.GetComponent<VideoPlayer>().clip.length;
        videoPlayer = GetComponent<VideoPlayer>();
        if (currentScene == "Skenario01")
        {
            Stop();
        }
    }

     void Update()
    {
        
        m_sceneName = SceneManager.GetActiveScene();
        currentScene = m_sceneName.name;
        skenarioDefault(currentScene);

        if (currentTime >= time-0.1)
        {
            gOCanvas.SetActive(true);
        }
    }



    public void skenarioDefault(string sceneSekarang) { 
        currentTime = videoPlayer.time;
        double timeChange = time-0.1;
        if (currentTime >= timeChange && sceneSekarang != "SkenarioMad" 
            && sceneSekarang != "Skenario09" && sceneSekarang != "CheckIn08" 
            && currentScene !="CheckOut_07" && sceneSekarang != "SkenarioMadCheckIn"
            && sceneSekarang != "SkenarioMadCheckOut"
            )
        {
            if (sceneSekarang.Contains("Skenario"))
            {
                SceneManager.UnloadScene(SceneManager.GetActiveScene());
                SceneManager.LoadScene("SkenarioMad");
            }
           else if (sceneSekarang.Contains("CheckIn"))
            {
                SceneManager.UnloadScene(SceneManager.GetActiveScene());
                SceneManager.LoadScene("SkenarioMadCheckIn");
            }else if (sceneSekarang.Contains("CheckOut"))
            { 
            SceneManager.UnloadScene(SceneManager.GetActiveScene());
            SceneManager.LoadScene("SkenarioMadCheckOut");
            }
        }
    }


    public void Play()
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void Stop()
    {
        videoPlayer.Stop();
    }

    public void UrlToVideo(string url)
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = url;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    

    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }
    
}
