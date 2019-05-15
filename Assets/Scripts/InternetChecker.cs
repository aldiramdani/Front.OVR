
using UnityEngine;

public class InternetChecker : MonoBehaviour
{
    private const bool allowCarrierDataNetwork = false;
    private const string pingAddress = "8.8.8.8"; // Google Public DNS server
    private const float waitingTime = 1.0f;
    public bool internetConnectBool;
    private Ping ping;
    private float pingStartTime;
    public void Start()
    {
        InternetCheck();
        if (PlayerPrefs.GetInt("tutorialStatus") == 0)
        {
            var ds = new DataService("tempDB.db");
            ds.DeleteDB();
        }
    }

    public void InternetCheck()
    {
        Invoke("InternetCheck", 5f);
        bool internetPossiblyAvailable;
        switch (Application.internetReachability)
        {
            case NetworkReachability.ReachableViaLocalAreaNetwork:
                internetPossiblyAvailable = true;
                break;
            case NetworkReachability.ReachableViaCarrierDataNetwork:
                //internetPossiblyAvailable = allowCarrierDataNetwork;
                internetPossiblyAvailable = true;
                break;
            default:
                internetPossiblyAvailable = false;
                break;
        }
        if (!internetPossiblyAvailable)
        {
            InternetIsNotAvailable();
            return;
        }
        ping = new Ping(pingAddress);
        pingStartTime = Time.time;

    }

    public void mulaiAplikasi()
    {
        PlayerPrefs.SetInt("vrActive", 0);
        if (!internetConnectBool)
        {
            SSTools.ShowMessage("Tidak Ada Koneksi Internet!", SSTools.Position.bottom, SSTools.Time.threeSecond);
        }
        else
        {
            SceneController sc = new SceneController();
            sc.ChangeScene("SampleScene");
        }
    }

    public void Update()
    {
        checkPing();

    }

    public void checkPing()
    {
        if (ping != null)
        {
            bool stopCheck = true;
            if (ping.isDone)
                InternetAvailable();
            else if (Time.time - pingStartTime < waitingTime)
                stopCheck = false;
            else
                InternetIsNotAvailable();
            if (stopCheck)
                ping = null;
        }
    }

    public void InternetIsNotAvailable()
    {
        //Debug.Log("No Internet");

        internetConnectBool = false;
    }

    public void InternetAvailable()
    {
        //Debug.Log("Internet is available;)");

        internetConnectBool = true;
    }
}
