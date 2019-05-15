using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject infoObject;
    private bool Show = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowAndHideInfo()
    {
        if (!Show)
        {
            infoObject.SetActive(true);
            Show = true;
        }
        else
        {
            infoObject.SetActive(false);
            Show = false;
        }
    }
}
