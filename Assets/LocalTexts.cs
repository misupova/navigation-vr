using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTexts
{
    public static string Language = "en";

    public const string English = "en";

    public const string Latvian = "lv";

    public static string STRING_001
    {
        get
        {
            switch (LocalTexts.Language)
            {
                case LocalTexts.Latvian:
                    return "Sveiki";
                case LocalTexts.English:
                    return "Hello";
                default:
                    return "Hello";
            }
        }
    }
}
