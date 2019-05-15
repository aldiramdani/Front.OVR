using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Words : IEquatable<Words>
{
    public string kataKunci { get; set; }
    public string skenarioTujuan { get; set;}
    public int nilai { get; set; }
    public bool isShellCommand { get; set; }
    public string toDo { get; set; }

    public bool Equals(Words other)
    {
        throw new NotImplementedException();
    }
}
