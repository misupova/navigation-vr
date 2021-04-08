using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_ErrorWindow : MonoBehaviour
{
    private static UI_ErrorWindow instance;

    private Button closeBtn;
    private TextMeshProUGUI errorText;
    private TextMeshProUGUI closeBtnText;

    private void Awake()
    {
        instance = this;

        closeBtn = transform.Find("closeBtn").GetComponent<Button>();
        closeBtnText = transform.Find("closeBtn").GetComponentInChildren<TextMeshProUGUI>();

        closeBtn.onClick.AddListener(() => {Hide(); UI_Blocker.Hide_Static();});

        errorText = instance.transform.Find("errorText").GetComponent<TextMeshProUGUI>();

        Hide();
    }

    private void CreateLocalTexts()
    {
        errorText.text = LocalTexts.errorText;
        closeBtnText.text = LocalTexts.closeBtnText;
    }

    private void Show()
    {
        gameObject.SetActive(true);
        transform.SetAsLastSibling();
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

    public static void Hide_static()
    {
        instance.CreateLocalTexts();
        instance.Hide();
    }
}
