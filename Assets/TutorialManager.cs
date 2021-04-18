using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;

    public GameObject[] tutorialItems;

    public GameObject UI_RemainingItems;

    public GameObject myDoor;

    [SerializeField]
    float waitTime = 1f;

    private int popUpIndex;

    bool mouseMovedLeft;

    bool mouseMovedRight;

    bool wentLeft;

    bool wentRight;

    bool wentForward;

    TextMeshProUGUI UI_MoveMouseText;

    TextMeshProUGUI UI_MoveAroundText;

    TextMeshProUGUI UI_TouchText;

    TextMeshProUGUI UI_CollectAllText;

    TextMeshProUGUI UI_TutorialFinishedText;

    TextMeshProUGUI UI_ReturnBackText;

    TextMeshProUGUI UI_ThankYouText;

    void Awake()
    {
        for (int i = 0; i < tutorialItems.Length; i++)
        {
            tutorialItems[i].SetActive(false);
        }
        UI_RemainingItems.SetActive(false);

        UI_MoveMouseText = GameObject.Find("UI_MoveMouse").GetComponentInChildren<TextMeshProUGUI>();
        UI_MoveAroundText = GameObject.Find("UI_MoveAround").GetComponentInChildren<TextMeshProUGUI>();
        UI_TouchText = GameObject.Find("UI_Touch").GetComponentInChildren<TextMeshProUGUI>();
        UI_CollectAllText = GameObject.Find("UI_CollectAll").GetComponentInChildren<TextMeshProUGUI>();
        UI_TutorialFinishedText = GameObject.Find("UI_TutorialFinished").GetComponentInChildren<TextMeshProUGUI>();
        UI_ReturnBackText = GameObject.Find("UI_ReturnBack").GetComponentInChildren<TextMeshProUGUI>();
        CreateLocalTexts();
    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (
            popUpIndex == 0 // Move mouse
        )
        {
            if (Input.GetAxis("Mouse X") < -1)
            {
                mouseMovedLeft = true;
            }
            if (Input.GetAxis("Mouse X") > 1)
            {
                mouseMovedRight = true;
            }
            if (mouseMovedLeft && mouseMovedRight)
            {
                popUpIndex++;
            }
        }
        else if (
            popUpIndex == 1 // Move around
        )
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                wentLeft = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                wentRight = true;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                wentForward = true;
            }
            if (wentLeft && wentRight && wentForward)
            {
                if (waitTime <= 0)
                {
                    popUpIndex++;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
        else if (
            popUpIndex == 2 // Collect items
        )
        {
            UI_RemainingItems.SetActive(true);
            UI_RemainingItems.GetComponentInChildren<TextMeshProUGUI>(true).text =
                LocalTexts.itemsRemaining[CollectItems.collectedTutorialItems];
            for (int i = 0; i < tutorialItems.Length; i++)
            {
                tutorialItems[i].SetActive(true);
            }
            if (CollectItems.collectedTutorialItems == 1)
            {
                popUpIndex++;
            }
        }
        else if (
            popUpIndex == 3 // Now collect all 3 items
        )
        {
            if (CollectItems.collectedTutorialItems < 3)
            {
                UI_RemainingItems.GetComponentInChildren<TextMeshProUGUI>(true).text =
                    LocalTexts.itemsRemaining[CollectItems.collectedTutorialItems];
            }
            else
            {
                UI_RemainingItems.SetActive(false);
                popUpIndex++;
            }
        }
        else if (
            popUpIndex == 4 // Tutorial finished
        )
        {
            myDoor.transform.rotation = Quaternion.Euler(0, 5f, 0);
            if (CollectItems.tutorialFinished)
            {
                popUps[popUpIndex].SetActive(false);
            }
        }
    }

    private void CreateLocalTexts()
    {
        UI_MoveMouseText.text = LocalTexts.UI_MoveMouseText;
        UI_MoveAroundText.text = LocalTexts.UI_MoveAroundText;
        UI_TouchText.text = LocalTexts.UI_TouchText;
        UI_CollectAllText.text = LocalTexts.UI_CollectAllText;
        UI_TutorialFinishedText.text = LocalTexts.UI_TutorialFinishedText;
        UI_ReturnBackText.text = LocalTexts.UI_ReturnBackText;
    }
}
