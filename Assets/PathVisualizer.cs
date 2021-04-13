using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class PathVisualizer : MonoBehaviour
{

    public LineFactory lineFactory;
    public float lineWidth = 0.2f;
    public int visualizeInterval = 10;

    List<InputTracker.Movement> movementList;

    void Start()
    {
        string path = Application.dataPath;
        path = Path.Combine(path, "MovementLogs", "2021_04_11_23_19_22.xml");
        System.Xml.Serialization.XmlSerializer reader =
    new System.Xml.Serialization.XmlSerializer(typeof(List<InputTracker.Movement>));
        System.IO.StreamReader file = new System.IO.StreamReader(
            @path);
        movementList = (List<InputTracker.Movement>)reader.Deserialize(file);
        file.Close();
        print(movementList);
    }


    // For some reason doesn't work with Start(), so use flag to execute visualization only once
    bool flag = true;
    void Update()
    {
        if (flag)
        {
            for (int i = 0; i < movementList.Count; i = i + visualizeInterval)
            {
                Vector3 lineStart;
                Vector3 lineEnd;

                lineStart = new Vector3(movementList[i].position.x, movementList[i].position.y, movementList[i].position.z);

                if (i + visualizeInterval < movementList.Count - 1)
                {
                    lineEnd = new Vector3(movementList[i + visualizeInterval].position.x, movementList[i + visualizeInterval].position.y, movementList[i + visualizeInterval].position.z);
                }
                else
                {
                    lineEnd = new Vector3(movementList[movementList.Count - 1].position.x, movementList[movementList.Count - 1].position.y, movementList[movementList.Count - 1].position.z);
                }

                float lineHeight = (lineStart.y + lineEnd.y) / 2;
                Line drawnLine = lineFactory.GetLine(new Vector2(lineStart.x, lineStart.z), new Vector2(lineEnd.x, lineEnd.z), lineHeight, lineWidth, Color.black);

            }
            flag = false;
        }


    }


}
