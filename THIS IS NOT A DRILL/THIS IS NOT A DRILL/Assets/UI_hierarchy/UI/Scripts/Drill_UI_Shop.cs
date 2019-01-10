using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Drill.UI
{
    public class Drill_UI_Shop : MonoBehaviour
    {
        #region Variables

        #endregion

        #region Main Methods

        #endregion

        #region Helper Methods

        public void BackButton()
        {
            if (SceneManager.GetSceneByName("MainMenuScene") != null)
            {
                SceneManager.LoadScene("MainMenuScene");
            }
            else
            {
                Debug.Log("MainMenuScene does not exist!");
            }

        }
        #endregion
    }
}

