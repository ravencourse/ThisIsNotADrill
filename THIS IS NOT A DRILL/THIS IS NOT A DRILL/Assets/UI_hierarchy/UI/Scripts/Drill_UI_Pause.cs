using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Drill.UI
{
    public class Drill_UI_Pause : MonoBehaviour
    {
        #region Variable

        private string objectiveName;

        public bool GameIsPaused = true;
        public GameObject pauseMenuUI;


        #endregion

        #region Main Methods

        public void Start()
        {
            objectiveName = GetComponentInChildren<Text>().name;
        }

        #endregion

        #region Helper Methods

        public void Quit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            //SceneManager.LoadScene("MainMenuScene");
            #else
            Application.Quit();
            #endif
        }

        public void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        public void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        public void Restart()
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
    }

    #endregion
}


