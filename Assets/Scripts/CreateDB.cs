using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class CreateDB : MonoBehaviour {
    public Text DebutText,tanggalText,skenarioText,nilaiText;
    DateTime dateTime = DateTime.Now;
    // Use this for initialization
    SceneController1 sc1 = new SceneController1();
    void Start()
    {
        StartSync();

    }

    // Update is called once per frame
    void Update()
    {
        sc1.resetScores();
    }

    private void StartSync()
    {
        var ds = new DataService("tempDB.db");
        var score = ds.GetScore();
        
        ToConsole(score);
    }

    private void ToConsole(IEnumerable<Score> scores)
    {
        foreach (var score in scores)
        {
            ToConsole(score.getId(),score.getTanggal(),score.getSkenario(),score.getNilai());
        }
    }

    private void ToConsole(string msg,string tanggal,string skenario,string nilai)
    {
        DebutText.text += System.Environment.NewLine + msg;
        tanggalText.text += System.Environment.NewLine + tanggal;
        skenarioText.text += System.Environment.NewLine + skenario;
        nilaiText.text += System.Environment.NewLine + nilai;
        Debug.Log(msg);
    }


}
