using Mechanic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ScoreUIController : MonoBehaviour
    {
        private GameScore level;
        private Text textUI;

        void Awake()
        {
            textUI = GetComponent<Text>();
            level = FindObjectOfType<GameScore>();
        }

        void Update()
        {
            textUI.text = level.Score.ToString();
        }
    }
}