using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GvrButton : MonoBehaviour {

    public Image imgCricle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float GvrTimer;


	
	// Update is called once per frame
	void Update ()
    {
        if (gvrStatus)
        {
            GvrTimer += Time.deltaTime;
            imgCricle.fillAmount = GvrTimer / totalTime;
            
        }	
        if(GvrTimer > totalTime)
        {
            GvrOff();
            GVRClick.Invoke();
        }
	}

    public void GvrOn()
    {
        gvrStatus = true;
    
    }

    public void GvrOff()
    {
        gvrStatus = false;
        GvrTimer = 0;
        imgCricle.fillAmount = 0;
    }
}
