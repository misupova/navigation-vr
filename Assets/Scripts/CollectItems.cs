using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Unity​Engine.XR.Interaction.Toolkit;

public class CollectItems : MonoBehaviour
{
    public static int collectedTutorialItems;

    public static int collectedItems;

    public static bool tutorialFinished;

    public GameObject UI_ReturnBack;

    public Button closeButton;

    public GameObject finishPlane;

    public Material successGreen;

    GameObject[] collectibles;

    GameObject rig;

    GameObject mainCamera;

    GameObject leftHandController;

    GameObject rightHandController;
    
    GameObject UIWrapper;

    bool showOnce = true;

    void Awake()
    {
        UI_ReturnBack.SetActive(false);
        closeButton.GetComponent<Button>().onClick.AddListener(closeUI);

        rig = GameObject.Find("XR Rig"); 
        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        mainCamera = GameObject.Find("Main Camera");

        UIWrapper = GameObject.Find("XR UI"); 

        leftHandController = GameObject.Find("LeftHand Controller");
        rightHandController = GameObject.Find("RightHand Controller");

        collectibles = GameObject.FindGameObjectsWithTag("Collectible");
    }

    void Update()
    {


        if (collectedItems == 3 & showOnce)
        {
            Vector3 playerDirection = mainCamera.transform.forward;
            Vector3 playerRotation = mainCamera.transform.rotation.eulerAngles;
            float spawnDistance = 0.162f;

            UI_ReturnBack.SetActive(true);
            finishPlane.SetActive(true);


            UIWrapper.transform.position = rig.transform.position + playerDirection*spawnDistance; 
            UIWrapper.transform.position += new Vector3 (0, 1.3f, 0);
            UIWrapper.transform.rotation = Quaternion.Euler(playerRotation.x, playerRotation.y, 0);

            rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
            leftHandController.GetComponent<XRRayInteractor>().enabled = true;
            rightHandController.GetComponent<XRRayInteractor>().enabled = true;

            for (int i = 0; i < collectibles.Length; i++)
            {
                collectibles[i].SetActive(false);
            }

            showOnce = false;
            
        }

    }

    public void OnTriggerEnter(Collider other)
    {

        Debug.Log("Collision");
        // If goal was triggered stop recording
        if (other.CompareTag("TutorialCollectible"))
        {
            other.tag = "Untagged";
            collectedTutorialItems++;
            Debug.Log (collectedTutorialItems);
            ParticleSystem ps =
                GameObject.Find(other.GetComponent<Collider>().gameObject.name).GetComponent<ParticleSystem>();
            ps.Play();
            GameObject.Find(other.GetComponent<Collider>().gameObject.name).GetComponent<Renderer>().material = successGreen;
        }

        if (other.CompareTag("Respawn"))
        {
            GameObject.Find(other.GetComponent<Collider>().gameObject.name).SetActive(false);
            tutorialFinished = true;
        }

        if (other.CompareTag("Collectible"))
        {
            other.tag = "Untagged";
            collectedItems++;
            Debug.Log (collectedItems);
            ParticleSystem ps =
                GameObject.Find(other.GetComponent<Collider>().gameObject.name).GetComponent<ParticleSystem>();
            ps.Play();
            GameObject.Find(other.GetComponent<Collider>().gameObject.name).GetComponent<Renderer>().material = successGreen;
        }
    }

    void closeUI()
    {
        UI_ReturnBack.SetActive(false);

        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        leftHandController.GetComponent<XRRayInteractor>().enabled = false;
        rightHandController.GetComponent<XRRayInteractor>().enabled = false;

        for (int i = 0; i < collectibles.Length; i++)
        {
            collectibles[i].SetActive(true);
        }
    }
}
