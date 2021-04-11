using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;

    public float waitTime = 2f;

    private int popUpIndex;

    bool mouseMovedLeft;

    bool mouseMovedRight;

    bool wentLeft;

    bool wentRight;

    bool wentForward;

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
        }
    }
}
