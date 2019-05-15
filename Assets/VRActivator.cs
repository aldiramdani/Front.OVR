using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
public class VRActivator : MonoBehaviour {
    string lastScene;
    bool vrActivStatus;
	// Use this for initialization
	public void Start () {
        if (PlayerPrefs.GetInt("vrActive") != 1)
        {
            StartCoroutine(ActivatorVR("Cardboard"));
        }
    }
    
    public IEnumerator ActivatorVR(string YESVR)
    {
        XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        XRSettings.enabled = true;
        PlayerPrefs.SetInt("vrActive", 1);
    }

}
