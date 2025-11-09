using UnityEngine;
using UnityEditor;

namespace NaxtorGames.VehicleController.EditorScripts
{
    [CustomPropertyDrawer(typeof(PhysicsLayerAttribute))]
    public sealed class PhysicsLayerAttributeDrawer : PropertyDrawer
    {
        private static bool s_isDirty = true;
        private static readonly GUIContent[] s_layerNames = new GUIContent[32];

        private static GUIContent[] LayerNames
        {
            get
            {
                if (s_isDirty)
                {
                    UpdateLayerNames();
                }

                return s_layerNames;
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType != SerializedPropertyType.Integer)
            {
                EditorGUI.LabelField(position, "Use [PhysicsLayer] with int.");
                return;
            }

            int currentLayer = Mathf.Clamp(property.intValue, 0, 31);
            int newLayer = EditorGUI.Popup(position, label, currentLayer, LayerNames);

            if (currentLayer != newLayer)
            {
                property.intValue = newLayer;
            }
        }

        [MenuItem("Tools/Update Layer Names")]
        private static void ForceLayerNamesUpdate()
        {
            s_isDirty = true;
        }

        [InitializeOnLoadMethod]
        private static void UpdateLayerNames()
        {
            for (int i = 0; i < s_layerNames.Length; i++)
            {
                GUIContent layerContent = s_layerNames[i] ??= new GUIContent();
                string layerName = LayerMask.LayerToName(i);
                layerContent.text = $"{i}: {(string.IsNullOrWhiteSpace(layerName) ? "-" : layerName)}";
                layerContent.tooltip = $"Layer {i}";
            }

            s_isDirty = false;
        }
    }
}
