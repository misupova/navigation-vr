using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_InputWindow : MonoBehaviour
{
    private static UI_InputWindow instance;

    private Button continueBtn;
    private TMP_InputField inputField;
    private TextMeshProUGUI STRING_001;

    private void Awake() {
        instance = this;
        
        STRING_001 = transform.Find("STRING_001").GetComponent<TextMeshProUGUI>();
        continueBtn = transform.Find("continueBtn").GetComponent<Button>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();
        
        Hide();
    }

    void Update() {
        STRING_001.text = LocalTexts.STRING_001;
        // Debug.Log(inputField.text);
    }

    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }

    public static void Show_Static() {
        instance.Show();
    }
}
