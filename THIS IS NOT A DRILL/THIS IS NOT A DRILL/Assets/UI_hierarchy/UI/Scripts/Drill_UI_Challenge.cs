using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Drill.UI
{
    public class Drill_UI_Challenge : MonoBehaviour
    {
        #region Variables

        private string date;

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

        public void CurrentDate()
        {
            string day = System.DateTime.Now.ToString("dd");
            string month = System.DateTime.Now.ToString("MM");
            string year = System.DateTime.Now.ToString("yyyy");


            if(month == "01")
            {
                date = "January " + day + ", " + year;
                Debug.Log("Todays Date: " + date);
            }

        }
        #endregion
    }
}

