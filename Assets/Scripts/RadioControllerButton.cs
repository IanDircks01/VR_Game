#if (UNITY_EDITOR) 

using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(RadioController))]
public class RadioControllerButton : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        RadioController myScript = (RadioController)target;
        if (GUILayout.Button("Start Sound"))
        {
            myScript.StartSound();
        }

        if (GUILayout.Button("Stop Sound"))
        {
            myScript.StopSound();
        }
    }
}

#endif