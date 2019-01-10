using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Drill.UI
{
    public class Drill_UI_Menus : MonoBehaviour
    {
        [MenuItem("Component/This Is Not A Drill/UI Tools/Create Menu")]
        public static void CreateMenu()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Menu.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Menu";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Menu Prefab", "OK");
            }
        }

        [MenuItem("Component/This Is Not A Drill/UI Tools/Create Menu with Banner")]
        public static void CreateMenuWithBanner()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Menu_w_Banner.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Menu_w_Banner";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Menu With Banner Prefab", "OK");
            }
        }

        [MenuItem("Component/This Is Not A Drill/UI Tools/Create Pause Menu")]
        public static void CreatePauseMenu()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Pause_Menu.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Pause_Menu";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Pause Menu Prefab", "OK");
            }
        }

        [MenuItem("Component/This Is Not A Drill/Shop Tools/Create Upgrade Template")]
        public static void CreateUpgradeTemplate()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Upgrade_Item_Template.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Upgrade_Item_Template";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Upgrade Item Template Prefab", "OK");
            }
        }

        [MenuItem("Component/This Is Not A Drill/Shop Tools/Create Boost Template")]
        public static void CreateBoostTemplate()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Boost_Item_Template.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Boost_Item_Template";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Boost Item Template Prefab", "OK");
            }
        }

        [MenuItem("Component/This Is Not A Drill/Shop Tools/Create Objective Template")]
        public static void CreateObjectiveTemplate()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/This is not a Drill/UI/Prefabs/Objective_Template.prefab");
            if (uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "Objective_Template";
            }
            else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find Objective Template Prefab", "OK");
            }
        }


    }

}
