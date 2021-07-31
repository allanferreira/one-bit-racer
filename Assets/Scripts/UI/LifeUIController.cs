using Controller;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UI
{
    public class LifeUIController : MonoBehaviour
    {

        [HideInInspector] public List<GameObject> lifes = new List<GameObject>();
        private PlayerController player;

        void Awake()
        {
            player = FindObjectOfType<PlayerController>();
            lifes = GetComponentsInChildren<Transform>()
                        .Select(children => children.gameObject)
                        .Where(gameObject => gameObject.CompareTag("Life"))
                        .ToList();
        }

        void Update()
        {
            foreach (var life in lifes)
            {
                life.SetActive(false);
            }

            for (int i = 0; i < player.Lifes; i++)
            {
                lifes[i].SetActive(true);
            }
        }
    }
}