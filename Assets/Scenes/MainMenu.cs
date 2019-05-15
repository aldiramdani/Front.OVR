using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    void Start()
    {
        SceneController1 sc1 = new SceneController1();
        sc1.loadKataKunci();
        Debug.Log("persistent data path: " + Application.persistentDataPath);
        Debug.Log(PlayerPrefs.GetString("lastScene"));
    }


}
