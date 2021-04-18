using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_ThankYou : MonoBehaviour
{
    private static UI_ThankYou instance;

    private TextMeshProUGUI STRING_011;

    void Awake()
    {
        instance = this;

        STRING_011 = transform.Find("STRING_011").GetComponent<TextMeshProUGUI>();

        Hide();
    }

    private void CreateLocalTexts()
    {
        STRING_011.text = LocalTexts.STRING_011;
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void Show_Static()
    {
        instance.CreateLocalTexts();
        instance.Show();
    }
}
