using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_InfoWindow : MonoBehaviour
{
    public static string playerId = System.Guid.NewGuid().ToString();

    private readonly System.Random _random = new System.Random();

    private static UI_InfoWindow instance;

    private Button continueBtn;

    private TextMeshProUGUI continueBtnText;

    private TextMeshProUGUI STRING_001;

    private int nextLevel;

    void Start()
    {
        StartCoroutine(GetText());
    }

    void Awake()
    {
        instance = this;

        STRING_001 = transform.Find("STRING_001").GetComponent<TextMeshProUGUI>();

        continueBtn = transform.Find("continueBtn").GetComponent<Button>();
        continueBtnText = transform.Find("continueBtn").GetComponentInChildren<TextMeshProUGUI>();

        continueBtn.onClick.AddListener (continueAction);

        Hide();
    }

    private void continueAction()
    {
        Hide();
        Invoke("UI_InputWindow.Show_Static", 2);
        SceneManager.LoadScene (nextLevel);
    }

    private void CreateLocalTexts()
    {
        STRING_001.text = LocalTexts.STRING_001;

        continueBtnText.text = LocalTexts.continueBtnText;
    }

    IEnumerator GetText()
    {
        using (
            UnityWebRequest www =
                UnityWebRequest.Get("https://navigation-experiment-server-xn9eu.ondigitalocean.app/generate_level")
        )
        {
            yield return www.Send();

            Debug.Log (www);

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                Debug.Log(www.downloadHandler.text);

                nextLevel = Int16.Parse(www.downloadHandler.text);

                // Or retrieve results as binary data
                byte[] results = www.downloadHandler.data;
            }
        }
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
