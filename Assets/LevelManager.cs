using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int currentLevel;

    int maxLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        maxLevel = SceneManager.sceneCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Debug.isDebugBuild)
        {
            int nextLevel;

            if (Input.GetKey(KeyCode.L))
            {
                if (currentLevel < maxLevel)
                {
                    nextLevel = currentLevel + 1;
                }
                else
                {
                    nextLevel = 0;
                }

                SceneManager.LoadScene (nextLevel);
            }
        }
    }
}
