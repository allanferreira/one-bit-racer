using Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class FinalScoreUIController : MonoBehaviour
    {
        public Score scoreData;
        private Text textUI;

        void Awake()
        {
            textUI = GetComponent<Text>();
        }

        void Update()
        {
            textUI.text = scoreData.value.ToString();
        }
    }
}