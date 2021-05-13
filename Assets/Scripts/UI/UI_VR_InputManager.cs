using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class UI_VR_InputManager : MonoBehaviour
{
    public GameObject[] InputWindows;

    int InputWindowIndex;

    private PlayerData _playerData;

    private TMP_Dropdown genderDropdown;

    private TMP_Dropdown educationDropdown;

    private TMP_Dropdown videoGameDropdown;

    private TMP_Dropdown VRGameDropdown;

    private TMP_Dropdown navigationDropdown;

    private Slider ageSlider;

    private Slider motionSicknessSlider;

    private Slider difficultySlider;

    private Slider lostSlider;

    private Slider wayBackSlider;

    private string gender;

    private string playtime;

    private string education;

    private string navigationTools;

    private string VR_playtime;

    private string age;

    private string motionSickness;

    private string instruction_difficulty;
    
    private string felt_lost;

    private string easy_way_back;

    GameObject rig;

    GameObject mainCamera;

    GameObject canvas;

    void Awake()
    {
        genderDropdown = GameObject.Find("DROPDOWN_001").GetComponent<TMP_Dropdown>();
        educationDropdown = GameObject.Find("DROPDOWN_002").GetComponent<TMP_Dropdown>();
        videoGameDropdown = GameObject.Find("DROPDOWN_003").GetComponent<TMP_Dropdown>();
        VRGameDropdown = GameObject.Find("DROPDOWN_004").GetComponent<TMP_Dropdown>();
        navigationDropdown = GameObject.Find("DROPDOWN_005").GetComponent<TMP_Dropdown>();

        genderDropdown.RefreshShownValue();
        educationDropdown.RefreshShownValue();
        videoGameDropdown.RefreshShownValue();
        VRGameDropdown.RefreshShownValue();
        navigationDropdown.RefreshShownValue();

        ageSlider = GameObject.Find("SLIDER_001").GetComponent<Slider>();
        motionSicknessSlider = GameObject.Find("SLIDER_002").GetComponent<Slider>();
        difficultySlider = GameObject.Find("SLIDER_003").GetComponent<Slider>();
        lostSlider = GameObject.Find("SLIDER_004").GetComponent<Slider>();
        wayBackSlider = GameObject.Find("SLIDER_005").GetComponent<Slider>();

        for (int i = 0; i < InputWindows.Length - 1; i++)
        {
            if (i == InputWindows.Length - 2)
            {
                InputWindows[i].GetComponentInChildren<Button>().onClick.AddListener(submitAction);
            }
            else
            {
                InputWindows[i].GetComponentInChildren<Button>().onClick.AddListener(nextWindow);
            }
        }

        rig = GameObject.Find("XR Rig");
        mainCamera = GameObject.Find("Main Camera");
        canvas = GameObject.Find("Canvas");

        InputTracking.Recenter();

        // Vector3 playerDirection = mainCamera.transform.forward;
        // Vector3 playerRotation = mainCamera.transform.rotation.eulerAngles;
        // float spawnDistance = 4.75f;


        // canvas.transform.position = rig.transform.position + playerDirection*spawnDistance; 
        // canvas.transform.position += new Vector3 (0, 2.492f, 0);
        // canvas.transform.rotation = Quaternion.Euler(playerRotation.x, playerRotation.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < InputWindows.Length; i++)
        {
            if (i == InputWindowIndex)
            {
                InputWindows[i].SetActive(true);
            }
            else
            {
                InputWindows[i].SetActive(false);
            }
        }
    }

    void nextWindow()
    {
        InputWindowIndex += 1;
    }

    void submitAction()
    {
        gender = genderDropdown.options[genderDropdown.value].text;
        playtime = videoGameDropdown.options[videoGameDropdown.value].text;
        education = educationDropdown.options[educationDropdown.value].text;
        navigationTools = navigationDropdown.options[navigationDropdown.value].text;
        VR_playtime = VRGameDropdown.options[VRGameDropdown.value].text;

        age = ((int) ageSlider.value).ToString();
        motionSickness = ((int) motionSicknessSlider.value).ToString();
        instruction_difficulty = ((int) difficultySlider.value).ToString();
        felt_lost = ((int) lostSlider.value).ToString();
        easy_way_back = ((int) wayBackSlider.value).ToString();

        _playerData = new PlayerData();

        _playerData.playerId = TutorialManager.playerId;
        _playerData.gender = gender;
        _playerData.playtime = playtime;
        _playerData.education = education;
        _playerData.navigationTools = navigationTools;
        _playerData.VR_playtime = VR_playtime;

        _playerData.age = age;
        _playerData.motionSickness = motionSickness;
        _playerData.instruction_difficulty = instruction_difficulty;
        _playerData.felt_lost = felt_lost;
        _playerData.easy_way_back = easy_way_back;

        StartCoroutine(UpdatePlayer(_playerData.Stringify(),
        result =>
        {
            Debug.Log (result);
        }));
        InputWindowIndex += 1;
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
}
