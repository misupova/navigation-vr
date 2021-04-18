using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public static int collectedTutorialItems;

    public static int collectedItems;

    public static bool tutorialFinished;

    public GameObject UI_RemainingItems;

    public GameObject UI_ReturnBack;

    public GameObject finishPlane;

    public Material successGreen;

    [SerializeField]
    float waitTime = 10f;

    void Awake()
    {
        UI_ReturnBack.SetActive(false);
    }

    void Update()
    {
        if (tutorialFinished && collectedItems < 3)
        {
            UI_RemainingItems.SetActive(true);
            UI_RemainingItems.GetComponentInChildren<TextMeshProUGUI>(true).text =
                LocalTexts.itemsRemaining[collectedItems];
        }

        if (collectedItems == 3 && waitTime > 0)
        {
            UI_ReturnBack.SetActive(true);
            UI_RemainingItems.SetActive(false);
            finishPlane.SetActive(true);
            waitTime -= Time.deltaTime;
        }
        else
        {
            UI_ReturnBack.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
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
}
