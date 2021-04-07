using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LanguageSelect : MonoBehaviour
{
    private Button englishBtn;

    private Button latvianBtn;

    private void Awake()
    {
        englishBtn = transform.Find("englishBtn").GetComponent<Button>();
        latvianBtn = transform.Find("latvianBtn").GetComponent<Button>();

        englishBtn.onClick.AddListener (TaskOnClick);
    }

    void TaskOnClick()
    {
        Hide();
        UI_InputWindow.Show_Static();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
