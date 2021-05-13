using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_InputWindow : MonoBehaviour
{
    private static UI_InputWindow instance;

    private PlayerData _playerData;

    private TextMeshProUGUI STRING_002;

    private TextMeshProUGUI STRING_003;

    private TextMeshProUGUI STRING_004;

    private TextMeshProUGUI STRING_005;

    private TextMeshProUGUI STRING_006;

    private TextMeshProUGUI STRING_007;

    private TextMeshProUGUI STRING_008;

    private TextMeshProUGUI STRING_009;

    private TextMeshProUGUI STRING_010;

    private TMP_Dropdown countryDropdown;

    private TMP_Dropdown genderDropdown;

    private TMP_Dropdown videoGameDropdown;

    private TMP_Dropdown educationDropdown;

    private TMP_Dropdown navigationDropdown;

    private TMP_Dropdown colorblindnessDropdown;

    private Button submitBtn;

    private TextMeshProUGUI submitBtnText;

    public static string country;

    public static string gender;

    public static string age;

    public static string playtime;

    public static string email;

    public static string education;

    public static string colorblindness;

    public static string navigationTools;

    private void Awake()
    {
        instance = this;

        Time.timeScale = 1;

        Cursor.visible = true;
        Screen.lockCursor = false;

        STRING_002 = transform.Find("STRING_002").GetComponent<TextMeshProUGUI>();
        STRING_003 = transform.Find("STRING_003").GetComponent<TextMeshProUGUI>();
        STRING_004 = transform.Find("STRING_004").GetComponent<TextMeshProUGUI>();
        STRING_005 = transform.Find("STRING_005").GetComponent<TextMeshProUGUI>();
        STRING_006 = transform.Find("STRING_006").GetComponent<TextMeshProUGUI>();
        STRING_007 = transform.Find("STRING_007").GetComponent<TextMeshProUGUI>();
        STRING_008 = transform.Find("STRING_008").GetComponent<TextMeshProUGUI>();
        STRING_009 = transform.Find("STRING_009").GetComponent<TextMeshProUGUI>();
        STRING_010 = transform.Find("STRING_010").GetComponent<TextMeshProUGUI>();

        countryDropdown = transform.Find("DROPDOWN_001").GetComponent<TMP_Dropdown>();
        countryDropdown.options.Clear();

        genderDropdown = transform.Find("DROPDOWN_002").GetComponent<TMP_Dropdown>();
        genderDropdown.options.Clear();

        videoGameDropdown = transform.Find("DROPDOWN_003").GetComponent<TMP_Dropdown>();
        videoGameDropdown.options.Clear();

        educationDropdown = transform.Find("DROPDOWN_004").GetComponent<TMP_Dropdown>();
        educationDropdown.options.Clear();

        navigationDropdown = transform.Find("DROPDOWN_005").GetComponent<TMP_Dropdown>();
        navigationDropdown.options.Clear();

        colorblindnessDropdown = transform.Find("DROPDOWN_006").GetComponent<TMP_Dropdown>();
        colorblindnessDropdown.options.Clear();

        submitBtn = transform.Find("submitBtn").GetComponent<Button>();
        submitBtnText = transform.Find("submitBtn").GetComponentInChildren<TextMeshProUGUI>();

        submitBtn.onClick.AddListener (submitAction);

        CreateLocalTexts();
    }

    private void CreateLocalTexts()
    {
        STRING_002.text = LocalTexts.STRING_002;
        STRING_003.text = LocalTexts.STRING_003;
        STRING_004.text = LocalTexts.STRING_004;
        STRING_005.text = LocalTexts.STRING_005;
        STRING_006.text = LocalTexts.STRING_006;
        STRING_007.text = LocalTexts.STRING_007;
        STRING_008.text = LocalTexts.STRING_008;
        STRING_009.text = LocalTexts.STRING_009;
        STRING_010.text = LocalTexts.STRING_010;

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
        foreach (string t in LocalTexts.education_list)
        {
            educationDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
        }
        foreach (string t in LocalTexts.navigation_tools_list)
        {
            navigationDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
        }
        foreach (string t in LocalTexts.colorblindness_list)
        {
            colorblindnessDropdown.options.Add(new TMP_Dropdown.OptionData() { text = t });
        }

        submitBtnText.text = LocalTexts.submitBtnText;
    }

    private void submitAction()
    {
        country = LocalTexts.country_list[countryDropdown.value];
        gender = LocalTexts.gender_list[genderDropdown.value];
        playtime = LocalTexts.play_hours_per_week_list[videoGameDropdown.value];
        education = LocalTexts.education_list[educationDropdown.value];
        navigationTools = LocalTexts.navigation_tools_list[navigationDropdown.value];
        colorblindness = LocalTexts.colorblindness_list[colorblindnessDropdown.value];
        age = transform.Find("INPUT_001").GetComponent<TMP_InputField>().text;
        email = transform.Find("INPUT_002").GetComponent<TMP_InputField>().text;

        if (
            age.Length == 0 ||
            gender == "---" ||
            playtime == "---" ||
            education == "---" ||
            navigationTools == "---" ||
            colorblindness == "---"
        )
        {
            UI_Blocker.Show_Static();
            UI_ErrorWindow.Show_Static();
        }
        else
        {
            _playerData = new PlayerData();

            _playerData.playerId = TutorialManager.playerId;
            _playerData.country = UI_InputWindow.country;
            _playerData.gender = UI_InputWindow.gender;
            _playerData.age = UI_InputWindow.age;
            _playerData.education = UI_InputWindow.education;
            _playerData.playtime = UI_InputWindow.playtime;
            _playerData.email = UI_InputWindow.email;
            _playerData.colorblindness = UI_InputWindow.colorblindness;
            _playerData.navigationTools = UI_InputWindow.navigationTools;

            StartCoroutine(UpdatePlayer(_playerData.Stringify(),
            result =>
            {
                Debug.Log (result);
                Hide();
                UI_ThankYou.Show_Static();
            }));
        }
    }

    IEnumerator UpdatePlayer(string profile, System.Action<bool> callback = null)
    {
        using (
            UnityWebRequest request =
                new UnityWebRequest("https://navigation-experiment-server-xn9eu.ondigitalocean.app/movement_data_vr/" +
                    TutorialManager.playerId,
                    "PUT")
        )
        {
            request.SetRequestHeader("Content-Type", "application/json");
            byte[] bodyRaw = Encoding.UTF8.GetBytes(profile);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
                if (callback != null)
                {
                    callback.Invoke(false);
                }
            }
            else
            {
                if (callback != null)
                {
                    callback.Invoke(request.downloadHandler.text != "{}");
                }
            }
        }
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
