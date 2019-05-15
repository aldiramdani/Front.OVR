using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour {
    public GameObject textHasil;
    // Use this for initialization
    private void Start () {
        textHasil.GetComponent<Text>().text = PlayerPrefs.GetInt("nilai").ToString();
    }


}
