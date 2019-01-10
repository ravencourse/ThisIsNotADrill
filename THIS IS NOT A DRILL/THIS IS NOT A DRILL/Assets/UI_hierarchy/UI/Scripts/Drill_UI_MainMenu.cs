using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Drill.UI
{
    public class Drill_UI_MainMenu : MonoBehaviour
    {
        #region Variables
        #endregion

        #region Main Methods

        #endregion

        #region Helper Methods

        public void OnShopClick()
        {
            if (SceneManager.GetSceneByName("ShopScene") != null)
            {
                SceneManager.LoadScene("ShopScene");
            }
            else
            {
                Debug.Log("ShopScene does not exist!");
            }
        }

        public void OnDailyChallengeClick()
        {
            if (SceneManager.GetSceneByName("DailyChallengeScene") != null)
            {
                SceneManager.LoadScene("DailyChallengeScene");
            }
            else
            {
                Debug.Log("DailyChallengeScene does not exist!");
            }
        }

        public void OnPlayClick()
        {
            if (SceneManager.GetSceneByName("TestGameScene") != null)
            {
                SceneManager.LoadScene("TestGameScene");
            }
            else
            {
                Debug.Log("TestGameScene does not exist!");
            }
        }
        #endregion
    }
}

