using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanic
{
    public class GameLevel : MonoBehaviour
    {
        private int _difficulty = 1;
        private int increaseDifficultyTimerInSeconds = 10;

        public int Difficulty => _difficulty;

        void Awake()
        {
            StartCoroutine(IncreaseDifficultyCoroutine());
        }

        IEnumerator IncreaseDifficultyCoroutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(increaseDifficultyTimerInSeconds);
                IncreaseDifficulty();
            }
        }

        void IncreaseDifficulty()
        {
            if(_difficulty <= 6) _difficulty++;
        }

        public void Lose()
        {
            Time.timeScale = 0;
        }
    }
}
