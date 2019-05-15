using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SQLite4Unity3d;

public class Score
{
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public string tanggal { get; set; }
    public string skenario { get; set; }
    public int nilai { get; set; }
    public override string ToString()
    {
        return string.Format("{0}            {1}             {2}                                        {3}", id, tanggal, skenario,nilai);
    }
    public string getId()
    {
        return string.Format("{0}", id);
    }
    public string getTanggal()
    {
        return string.Format("{0}", tanggal);
    }
    public string getSkenario()
    {
        return string.Format("{0}", skenario);
    }
    public string getNilai()
    {
        return string.Format("{0}", nilai);
    }
}

