using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using ERNIXR;

namespace ERNIXR.UnityEditorTools
{
    [CustomEditor(typeof(AugmentedPathVisualizer))]
    public class AugmentedPathVisualizerEditor : Editor
    {
        SerializedProperty scriptProperty;
        SerializedProperty overrideSpawnHeightProperty;
        SerializedProperty customSpawnHeightProperty;
        SerializedProperty pathGameObjectProperty;

        // Use this for initialization
        void OnEnable () {

            scriptProperty = serializedObject.FindProperty("m_Script");
            pathGameObjectProperty= serializedObject.FindProperty("PathGameObject");
            overrideSpawnHeightProperty = serializedObject.FindProperty("overrideSpawnHeight");
            customSpawnHeightProperty = serializedObject.FindProperty("customSpawnHeight");
        }

        public override void OnInspectorGUI()
        {
            // base.OnInspectorGUI();
            serializedObject.Update();

            UnityEngine.GUI.enabled = false;
            EditorGUILayout.PropertyField(scriptProperty);
            UnityEngine.GUI.enabled = true;

            EditorGUILayout.PropertyField(pathGameObjectProperty);
            EditorGUILayout.PropertyField(overrideSpawnHeightProperty);
            if( overrideSpawnHeightProperty.boolValue )
            {
                EditorGUILayout.PropertyField(customSpawnHeightProperty);
            }
            else
            {
                UnityEngine.GUI.enabled = false;
                EditorGUILayout.PropertyField(customSpawnHeightProperty);
                UnityEngine.GUI.enabled = true;
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
