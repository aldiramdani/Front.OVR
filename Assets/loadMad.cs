using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class loadMad : MonoBehaviour {
    public Image imageStatus;
    public float totalTime = 25;
    bool gvrStatus;
    public float GvrTimer;

    // Update is called once per frame
    void Update () {
        GvrTimer += Time.deltaTime;
        imageStatus.fillAmount = GvrTimer / totalTime;
        if (GvrTimer > totalTime)
        {
            imageStatus.gameObject.SetActive(false);
        }
    }

}
