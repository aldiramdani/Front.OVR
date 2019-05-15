using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class SceneController1
{
    Scene m_sceneName;
    string[] keyWord;
    string currentScene;
    
    private List<Words> word = new List<Words>();
    

    public void sceneControl(string speakResult,string skenarioGanti,string skenario)
    {
        m_sceneName = SceneManager.GetActiveScene();
        currentScene = m_sceneName.name;
        
        if (currentScene == "Skenario01" || currentScene=="CheckIn01" || currentScene== "CheckOut_01")
        {
            PlayerPrefs.SetInt("nilai", 0);
            resetScores();
        }
        loadKataKunci();

        PlayerPrefs.GetInt("todo1");
        PlayerPrefs.GetInt("todo2");
        PlayerPrefs.GetInt("todo3");
        PlayerPrefs.GetInt("todo4");
        PlayerPrefs.GetInt("todo5");
        PlayerPrefs.GetInt("todo6");
        PlayerPrefs.GetInt("todo7");
        PlayerPrefs.GetInt("todo8");
        PlayerPrefs.GetInt("todo8");
        PlayerPrefs.GetInt("todo9");
        PlayerPrefs.GetInt("nilai");

        
        for (int i = 0; i < word.Count; i++)
        {
           if (speakResult.Contains(word[i].kataKunci))
                {
                if (word[i].skenarioTujuan.Contains(skenario))
                {
                    PlayerPrefs.SetInt(word[i].toDo, 1);
                    SceneManager.LoadScene(word[i].skenarioTujuan);
                    PlayerPrefs.SetInt("nilai", (PlayerPrefs.GetInt("nilai") + word[i].nilai));
                    SceneManager.UnloadScene(SceneManager.GetActiveScene());
                    SpeakNow.reset();
                    speakResult = "";
                }
            }else if (speakResult != "" && speakResult != word[i].kataKunci)
            {
                SceneManager.UnloadScene(SceneManager.GetActiveScene());
                SceneManager.LoadScene(skenarioGanti);
                SpeakNow.reset();
            }
        }
    }

    private static bool searchSkenarioTuj(Words word,string skenarioCari)
    {
        if (word.skenarioTujuan.Contains(skenarioCari))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
 

    public void loadKataKunci()
    {
        try
        {
            string path = "jar:file://" + Application.dataPath + "!/assets/word.txt";
            WWW wwfile = new WWW(path);
            while (!wwfile.isDone) { }
            var filepath = string.Format("{0}/{1}", Application.persistentDataPath, "word.txt");
            File.WriteAllBytes(filepath, wwfile.bytes);

            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                if (line.StartsWith("--") || line == String.Empty) continue;

                var parts = line.Split(new char[] { '|' });

                word.Add(new Words()
                {
                    kataKunci = parts[0],
                    skenarioTujuan = parts[1],
                    nilai = int.Parse(parts[2]),
                    isShellCommand = (parts[3] == "true"),
                    toDo = parts[4]
                });
            }
        }catch(Exception ex)
        {
            throw ex;
        }
    }

    public void resetScores()
    {
        PlayerPrefs.SetInt("todo1", 0);
        PlayerPrefs.SetInt("todo2", 0);
        PlayerPrefs.SetInt("todo3", 0);
        PlayerPrefs.SetInt("todo4", 0);
        PlayerPrefs.SetInt("todo5", 0);
        PlayerPrefs.SetInt("todo6", 0);
        PlayerPrefs.SetInt("todo7", 0);
        PlayerPrefs.SetInt("todo8", 0);
        PlayerPrefs.SetInt("todo9", 0);
        PlayerPrefs.SetInt("nilai", 0);
    }



}
