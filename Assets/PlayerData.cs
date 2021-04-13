using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerData
{
    public string playerId;

    public string XMLString;

    public int currentCollectedItems;

    public DateTime localDate; // = DateTime.Now;

    public bool isFinished;

    public string Stringify()
    {
        return JsonUtility.ToJson(this);
    }

    public static PlayerData Parse(string json)
    {
        return JsonUtility.FromJson<PlayerData>(json);
    }
}
