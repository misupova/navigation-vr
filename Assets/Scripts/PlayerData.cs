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

    public string VR_playtime;

    public string email;

    public string education;

    public string colorblindness;

    public string navigationTools;

    public string motionSickness;

    public string instruction_difficulty;

    public string felt_lost;

    public string easy_way_back;

    public int screenHeight;

    public int screenWidth;

    public float screenHeightInch;

    public float screenWidthInch;

    public string Stringify()
    {
        return JsonUtility.ToJson(this);
    }

    public static PlayerData Parse(string json)
    {
        return JsonUtility.FromJson<PlayerData>(json);
    }
}
