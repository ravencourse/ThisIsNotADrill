using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

namespace Drill.UI
{
    public class Drill_UI_Template_Creator : EditorWindow
    {
        string itemName;
        string itemDescription;
        string itemType;
        bool upgradeChosen;
        bool boostChosen;

        // [MenuItem("Component/This Is Not A Drill/Template Creator")]
        public static void ShowWindow()
        {
            GetWindow<Drill_UI_Template_Creator>("Template Creator");
        }


        private void OnGUI()
        {
            GUILayout.Label("Shop Template Creator", EditorStyles.boldLabel);

            upgradeChosen = EditorGUILayout.Toggle("Upgrade Item", upgradeChosen);
            if (upgradeChosen)
            {
                itemType = "Upgrade";
                boostChosen = false;
            }

            boostChosen = EditorGUILayout.Toggle("Boost Item", boostChosen);
            if (boostChosen)
            {
                itemType = "Boost";
                upgradeChosen = false;
            }

            itemName = EditorGUILayout.TextField("Item Name", itemName);
            itemDescription = EditorGUILayout.TextField("Item Description", itemDescription);


            if (GUILayout.Button("Create"))
            {
                if(itemType == "Upgrade")
                {
                    GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Upgrade_Item_Template.prefab");
                    if (uiGroup)
                    {
                        GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                        createdGroup.name = itemName;
                    }
                    else
                    {
                        EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Upgrade Item Template Prefab", "OK");
                    }
                }

                Debug.Log(itemName + " was created");
            }
        }
    }
}

