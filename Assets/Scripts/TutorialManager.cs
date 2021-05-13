using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity​Engine.XR.Interaction.Toolkit;

public class TutorialManager : MonoBehaviour
{
    public static string playerId = System.Guid.NewGuid().ToString();
    public GameObject[] popUps;

    public GameObject myDoor;

    public Button nextButton;

    public Button closeButton;

    public GameObject[] tutorialObjects;

    public GameObject UI_NoInternet;

    public Button closeNoInternetButton;

    GameObject rig;

    GameObject mainCamera;

    GameObject leftHandController;

    GameObject rightHandController;
    
    GameObject UIWrapper;

    bool tutorialFinished;


    void Awake()
    {
        rig = GameObject.Find("XR Rig"); 
        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        mainCamera = GameObject.Find("Main Camera");

        leftHandController = GameObject.Find("LeftHand Controller");
        rightHandController = GameObject.Find("RightHand Controller");

        UIWrapper = GameObject.Find("XR UI"); 

        Debug.Log(UIWrapper.transform.position);

        closeButton.gameObject.SetActive(false);

    
        for (int i = 0; i < popUps.Length; i++)
        {
            popUps[i].SetActive(false);
            
        }

        nextButton.GetComponent<Button>().onClick.AddListener(closeWelcomeUI);
        closeButton.GetComponent<Button>().onClick.AddListener(closeTutorial);
        closeNoInternetButton.GetComponent<Button>().onClick.AddListener(closeNoInternet);

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
            leftHandController.GetComponent<XRRayInteractor>().enabled = true;
            rightHandController.GetComponent<XRRayInteractor>().enabled = true;
            UI_NoInternet.SetActive(true);
        } else 
        {
            UI_NoInternet.SetActive(false);
            popUps[0].SetActive(true);
        }

    }


    void Update()
    {
        if (CollectItems.collectedTutorialItems == 3)
        {
            tutorialFinished = true;
            CollectItems.collectedTutorialItems = 0;
        }


        if (tutorialFinished)
        {
            foreach (var item in tutorialObjects)
            {
                item.SetActive(false);
            }

            Vector3 playerDirection = mainCamera.transform.forward;
            Vector3 playerRotation = mainCamera.transform.rotation.eulerAngles;
            float spawnDistance = 0.162f;

            myDoor.transform.rotation = Quaternion.Euler(0, 5f, 0);

            UIWrapper.transform.position = rig.transform.position + playerDirection*spawnDistance; 
            UIWrapper.transform.position += new Vector3 (0, 1.3f, 0);
            UIWrapper.transform.rotation = Quaternion.Euler(playerRotation.x, playerRotation.y, 0);
            popUps[1].SetActive(true);
            closeButton.gameObject.SetActive(true);

            rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
            leftHandController.GetComponent<XRRayInteractor>().enabled = true;
            rightHandController.GetComponent<XRRayInteractor>().enabled = true;

            tutorialFinished = false;
        }

    }
    void closeWelcomeUI()
    {
        popUps[0].SetActive(false);
        nextButton.gameObject.SetActive(false);
        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        leftHandController.GetComponent<XRRayInteractor>().enabled = false;
        rightHandController.GetComponent<XRRayInteractor>().enabled = false;
    }

    void closeTutorial()
    {
        popUps[1].SetActive(false);
        closeButton.gameObject.SetActive(false);
        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        leftHandController.GetComponent<XRRayInteractor>().enabled = false;
        rightHandController.GetComponent<XRRayInteractor>().enabled = false;
    }

    void closeNoInternet()
    {
        UI_NoInternet.SetActive(false);
        // rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        // leftHandController.GetComponent<XRRayInteractor>().enabled = false;
        // rightHandController.GetComponent<XRRayInteractor>().enabled = false;
        popUps[0].SetActive(true);
    }

}

