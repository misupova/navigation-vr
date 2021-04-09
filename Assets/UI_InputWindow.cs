using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_InputWindow : MonoBehaviour
{
    public static System.Guid playerId = System.Guid.NewGuid();

    private readonly System.Random _random = new System.Random();

    private static UI_InputWindow instance;

    private Button continueBtn;

    private TextMeshProUGUI STRING_001;

    private TextMeshProUGUI STRING_002;

    private TextMeshProUGUI STRING_003;

    private TextMeshProUGUI STRING_004;

    private TextMeshProUGUI STRING_005;

    private TextMeshProUGUI STRING_006;

    private TextMeshProUGUI continueBtnText;

    private TMP_Dropdown countryDropdown;

    private TMP_Dropdown genderDropdown;

    private TMP_Dropdown videoGameDropdown;

    private string country;

    private string gender;

    private string age;

    private string playtime;

    private string email;

    private void Awake()
    {
        instance = this;

        STRING_001 = transform.Find("STRING_001").GetComponent<TextMeshProUGUI>();
        STRING_002 = transform.Find("STRING_002").GetComponent<TextMeshProUGUI>();
        STRING_003 = transform.Find("STRING_003").GetComponent<TextMeshProUGUI>();
        STRING_004 = transform.Find("STRING_004").GetComponent<TextMeshProUGUI>();
        STRING_005 = transform.Find("STRING_005").GetComponent<TextMeshProUGUI>();
        STRING_006 = transform.Find("STRING_006").GetComponent<TextMeshProUGUI>();

        continueBtn = transform.Find("continueBtn").GetComponent<Button>();
        continueBtnText = transform.Find("continueBtn").GetComponentInChildren<TextMeshProUGUI>();

        countryDropdown = transform.Find("DROPDOWN_001").GetComponent<TMP_Dropdown>();
        countryDropdown.options.Clear();

        genderDropdown = transform.Find("DROPDOWN_002").GetComponent<TMP_Dropdown>();
        genderDropdown.options.Clear();

        videoGameDropdown = transform.Find("DROPDOWN_003").GetComponent<TMP_Dropdown>();
        videoGameDropdown.options.Clear();

        continueBtn.onClick.AddListener (continueAction);

        Hide();
    }

    // void Update()
    // {
    //     STRING_001.text = LocalTexts.STRING_001;
    //     foreach (string t in LocalTexts.country_list)
    //     {
    //         countryDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
    //     }
    // }
    private void CreateLocalTexts()
    {
        STRING_001.text = LocalTexts.STRING_001;
        STRING_002.text = LocalTexts.STRING_002;
        STRING_003.text = LocalTexts.STRING_003;
        STRING_004.text = LocalTexts.STRING_004;
        STRING_005.text = LocalTexts.STRING_005;
        STRING_006.text = LocalTexts.STRING_006;

        continueBtnText.text = LocalTexts.continueBtnText;

        foreach (string t in LocalTexts.country_list)
        {
            countryDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
        }
        foreach (string t in LocalTexts.gender_list)
        {
            genderDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
        }
        foreach (string t in LocalTexts.play_hours_per_week_list)
        {
            videoGameDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
        }
    }

    private void continueAction()
    {
        country = LocalTexts.country_list[countryDropdown.value];
        gender = LocalTexts.gender_list[genderDropdown.value];
        playtime = LocalTexts.play_hours_per_week_list[videoGameDropdown.value];
        age = transform.Find("INPUT_001").GetComponent<TMP_InputField>().text;
        email = transform.Find("INPUT_002").GetComponent<TMP_InputField>().text;

        if (age.Length == 0 || gender == "---" || playtime == "---")
        {
            UI_Blocker.Show_Static();
            UI_ErrorWindow.Show_Static();
        }
        else
        {
            SceneManager.LoadScene(RandomNumber(1, 3));
        }
    }

    private int RandomNumber(int min, int max)
    {
        return _random.Next(min, max);
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
