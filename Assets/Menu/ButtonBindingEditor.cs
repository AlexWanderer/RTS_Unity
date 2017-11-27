using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;

namespace Assets.Menu
{
    [CustomEditor(typeof(ButtonBinding))]
    [CanEditMultipleObjects]
    public class ButtonBindingEditor : Editor
    {
        SerializedProperty button;
        SerializedProperty action;

        private void OnEnable()
        {
            button = serializedObject.FindProperty("Button");
            action = serializedObject.FindProperty("ClickAction");
        }
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Button");
            EditorGUILayout.PropertyField(button);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Click Action");
            EditorGUILayout.PropertyField(action);
            EditorGUILayout.EndHorizontal();
            serializedObject.ApplyModifiedProperties();
        }
    }
}
