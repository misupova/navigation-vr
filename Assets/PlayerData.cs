using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string playerId;

    public string XMLString;

    public string createdAt;

    public bool isFinished;

    public string level;

    public string country;

    public string gender;

    public string age;

    public string playtime;

    public string email;

    public string education;

    public string Stringify()
    {
        return JsonUtility.ToJson(this);
    }

    public static PlayerData Parse(string json)
    {
        return JsonUtility.FromJson<PlayerData>(json);
    }
}
