using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Drill.UI
{
    public class Drill_UI_Master : MonoBehaviour
    {
        #region Variables

        string isPro;
        bool isPlayerPro;
        private int totalCoinInt;

        [Header("MainMenuScene Menu's")]
        public GameObject mainMenu;
        public GameObject mainMenuPro;

        [Header("Total Coin Counter")]
        public Text coinCount;

        #endregion

        #region Main Method
        public void Start()
        {
            Scene scene = SceneManager.GetActiveScene();
            isPlayerPro = IsPro(isPro);
            CoinUpdater();

            if(scene.name == "MainMenuScene")
            {
                MenuPicker();
            }
        }

        public void Update()
        {
            CoinUpdater();
        }

        #endregion

        #region Helper Methods

        public static void SetPro(string isPro, bool state)
        {
            PlayerPrefs.SetInt(isPro, state ? 1 : 0);
        }

        public static bool IsPro(string key)
        {
            int value = PlayerPrefs.GetInt(key);

            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void MenuPicker()
        {
            if (isPlayerPro)
            {
                mainMenu.SetActive(false);
                mainMenuPro.SetActive(true);
            }
            else
            {
                mainMenu.SetActive(true);
                mainMenuPro.SetActive(false);
            }
        }

        void CoinUpdater()
        {
            if(coinCount != null)
            {
                coinCount.text = "$ " + PlayerPrefs.GetInt("Coins", 0).ToString();
            }
            totalCoinInt = PlayerPrefs.GetInt("Coins", 0);
        }

        #endregion
    }
}

