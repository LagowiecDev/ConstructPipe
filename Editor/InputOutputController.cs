using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(InputCore))]
public class InputCoreEditor : Editor {
    public override void OnInspectorGUI() {

        if (GUILayout.Button("TEST ME !!!"))
        {
            // Your custom logic goes here
            Debug.Log("TEST CLICK");

            InputCore inputCore = (InputCore)target;

            inputCore.RunScript();
        }

        base.OnInspectorGUI();
        
    }
}

[CustomEditor(typeof(OutputCore))]
public class OutputCoreEditor : Editor {
    public override void OnInspectorGUI() {

        if (GUILayout.Button("TEST ME !!!"))
        {
            // Your custom logic goes here
            Debug.Log("TEST CLICK");

            OutputCore outputCore = (OutputCore)target;
            
            outputCore.onOutput();
        }        

        base.OnInspectorGUI();
        
    }
}