using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Controller
{
    public class SignsController : MonoBehaviour
    {
        [HideInInspector] public List<GameObject> signs = new List<GameObject>();
        private LevelController level;

        void Awake()
        {
            level = FindObjectOfType<LevelController>();
            signs = GetComponentsInChildren<Transform>()
                        .Select(children => children.gameObject)
                        .Where(gameObject => gameObject.CompareTag("Sign"))
                        .ToList();
        }

        public List<GameObject> SignsToDisable()
        {
            return signs
                       .OrderBy(a => Guid.NewGuid())
                       .Where(SignsDisableRule)
                       .ToList();
        }

        public void MoveForward()
        {
            transform.Translate(Vector3.left * SignsSpeedRule() * Time.deltaTime);
        }

        private float SignsSpeedRule()
        {
            if (level?.Difficulty >= 2) return 6f;
            else if (level?.Difficulty >= 5) return 8f;
            return 4f;
        }

        private bool SignsDisableRule(GameObject sign, int index)
        {
            var disabledByDefault = index >= UnityEngine.Random.Range(4, 6);
            return index >= level.Difficulty || disabledByDefault;
        }
    }
}