using System;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        private int positionRow = 2;
        private int _lifes = 3;
        private GameController game;

        [HideInInspector] public int Lifes => _lifes;

        private void Awake()
        {
            game = FindObjectOfType<GameController>();
        }

        public void MoveUp(float distance)
        {
            if (positionRow >= 6) return;
            transform.position = new Vector2(transform.position.x, transform.position.y + distance * Time.deltaTime);
            positionRow++;
        }

        public void MoveDown(float distance)
        {
            if (positionRow <= 1) return;
            transform.position = new Vector2(transform.position.x, transform.position.y - distance * Time.deltaTime);
            positionRow--;
        }

        public void Crached(GameObject collider)
        {
            _lifes--;

            if (_lifes <= 0)
            {
                game.Lose();
            }
            else
            {
                Destroy(collider);
            }
        }
    }
}
