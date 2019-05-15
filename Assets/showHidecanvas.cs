using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class showHidecanvas : MonoBehaviour {
    public GameObject PanelMad;
    VideoPlayer videoPlayer;
    public double time;
    public double currentTime;
    bool statusHide = false;
    void Start()
    {
        
        videoPlayer = GetComponent<VideoPlayer>();
        time = gameObject.GetComponent<VideoPlayer>().clip.length;
    }

    void Update()
    {
        currentTime = videoPlayer.time;
        showPanel();
        Debug.Log(statusHide);
        if (currentTime >= time);
        {
            PanelMad.SetActive(true);
        }
    }

    public void showPanel()
    {
        if (currentTime >= time)
        {
            statusHide = true;
        }

    }
}
