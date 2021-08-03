using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Score", order = 1)]
    public class Score : ScriptableObject
    {
        public int value;

        void Start()
        {
            value = 0;
        }
    }
}