using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class SignController : MonoBehaviour
    {
        private PlayerController player;

        void Awake()
        {
            player = FindObjectOfType<PlayerController>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag("Player")) return;
            player.Crached(gameObject);
        }
    }
}