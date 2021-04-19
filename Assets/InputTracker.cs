using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class InputTracker : MonoBehaviour
{
    // Time interval for movement recording
    public int frameInterfal = 4;

    private string XMLString;

    private PlayerData _playerData;

    public class Movement
    {
        public Vector3 position;

        public float

                time,
                distance;

        public int currentItem;

        //default constructor
        public Movement()
        {
            this.position = Vector3.zero;
            this.time = 0f;
            this.distance = 0f;
        }

        public Movement(Vector3 position)
        {
            this.position = position;
            this.time = Time.timeSinceLevelLoad;
            this.currentItem = CollectItems.collectedItems;
        }

        public void setDistance(float distance)
        {
            this.distance = distance;
        }
    }

    List<Movement> movements = new List<Movement>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Screen.height);
        Debug.Log(Screen.width);
        Debug.Log(Screen.height / Screen.dpi);
        Debug.Log(Screen.width / Screen.dpi);
        Transform playerTrans = this.transform;
        Transform camera = playerTrans.Find("FirstPersonCharacter");
    }

    int timer = 0;

    Transform cameraTransform;

    int currentMovementIndex = 0;

    bool levelCompleted = false;

    // Update is called once per frame
    void Update()
    {
        if (timer % frameInterfal == 0)
        {
            if (!levelCompleted && CollectItems.tutorialFinished)
            {
                cameraTransform = Camera.main.transform;
                movements.Add(new Movement(cameraTransform.position));
                currentMovementIndex++;
            }
        }
        timer++;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        // If goal was triggered stop recording
        if (!other.CompareTag("GoalTrigger") || levelCompleted) yield break;

        levelCompleted = true;

        for (int i = 0; i < movements.Count; i++)
        {
            if (i == 0)
            {
                movements[i].setDistance(0f);
            }
            else
            {
                movements[i].setDistance(Vector3.Distance(movements[i].position, movements[i - 1].position));
            }
        }

        XmlSerializer serialiser = new XmlSerializer(typeof (List<Movement>));

        // Create the StringWriter for the serialiser to use
        var sw = new StringWriter();

        //write to the variable
        serialiser.Serialize (sw, movements);
        XMLString = sw.ToString();

        _playerData = new PlayerData();

        _playerData.playerId = UI_InfoWindow.playerId;
        _playerData.XMLString = XMLString;
        _playerData.isFinished = true;
        _playerData.createdAt = DateTime.Now.ToString();
        _playerData.level = SceneManager.GetActiveScene().name;
        _playerData.screenHeight = Screen.height;
        _playerData.screenWidth = Screen.width;
        _playerData.screenHeightInch = Screen.height / Screen.dpi;
        _playerData.screenWidthInch = Screen.width / Screen.dpi;

        StartCoroutine(Upload(_playerData.Stringify(),
        result =>
        {
            Debug.Log (result);
            SceneManager.LoadScene(3);
        }));
    }


    IEnumerator Upload(string profile, System.Action<bool> callback = null)
    {
        using (
            UnityWebRequest request =
                new UnityWebRequest("https://navigation-experiment-server-xn9eu.ondigitalocean.app/movement_data",
                    "POST")
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
