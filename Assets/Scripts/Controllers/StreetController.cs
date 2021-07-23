using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class StreetController : MonoBehaviour
    {
        Vector3 initialPosition;
        private LevelController level;
        float width;

        void Awake()
        {
            width = GetComponent<SpriteRenderer>().bounds.size.x;
            level = FindObjectOfType<LevelController>();
            initialPosition = transform.position;
        }

        void Update()
        {
            var hasLeftTheScreen = transform.position.x <= initialPosition.x - width;
            if (hasLeftTheScreen)
            {
                transform.position = initialPosition;
            }
            else
            {
                transform.Translate(Vector3.left * BackgroundSpeedRule() * Time.deltaTime);
            }
        }

        private float BackgroundSpeedRule()
        {
            if (level?.Difficulty >= 2) return 6f;
            else if (level?.Difficulty >= 5) return 8f;
            return 4f;
        }
    }
}