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

    private void Awake() {
        instance = this;
        
        continueBtn = transform.Find("continueBtn").GetComponent<Button>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();
        
        Hide();
    }

    void Update() {
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
