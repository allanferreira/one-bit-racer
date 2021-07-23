using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanic
{
    public class GameScore : MonoBehaviour
    {
        int _score = 0;
        private GameLevel level;

        [HideInInspector] public int Score => _score;

        private void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 300;
        }

        void Awake()
        {
            level = FindObjectOfType<GameLevel>();
            StartCoroutine(IncreaseScoreCoroutine());
        }

        IEnumerator IncreaseScoreCoroutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(.5f);
                _score += 25;
            }
        }

        public void IncreaseBonusScore()
        {
            if (level?.Difficulty >= 2) _score += 150;
            else if (level?.Difficulty >= 5) _score += 200;
            else _score += 100;
        }
    }
}