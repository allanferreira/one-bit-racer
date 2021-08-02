using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class MainMenuButtonUIController : MonoBehaviour
    {
        Button button;

        void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(onClickHandler);
        }

        void onClickHandler()
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}