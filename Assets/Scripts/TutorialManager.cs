using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity​Engine.XR.Interaction.Toolkit;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;

    public GameObject myDoor;

    public Button nextButton;
    GameObject rig;


    bool tutorialFinished;


    void Awake()
    {
        rig = GameObject.Find("XR Rig"); 
        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
    
        for (int i = 1; i < popUps.Length; i++)
        {
            popUps[i].SetActive(false);
            
        }
    nextButton.GetComponent<Button>().onClick.AddListener(closeWelcomeUI);


    }

    void closeWelcomeUI()
    {
        popUps[0].SetActive(false);
        nextButton.gameObject.SetActive(false);
        rig.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
    }

    void Update()
    {


        if (tutorialFinished)
        {
            myDoor.transform.rotation = Quaternion.Euler(0, 5f, 0);
        }
    }

}
