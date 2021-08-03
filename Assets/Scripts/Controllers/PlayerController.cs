using Mechanic;
using System;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        public AudioClip hitAudioClip;
        public AudioClip loseAudioClip;
        private int positionRow = 2;
        private int _lifes = 3;
        private GameLevel level;
        AudioSource audioData;

        [HideInInspector] public int Lifes => _lifes;

        private void Awake()
        {
            audioData = GetComponent<AudioSource>();
            var positionInScreen = Camera.main.ScreenToWorldPoint(new Vector3(100, 0));
            transform.position = new Vector3(positionInScreen.x, transform.position.y);
            level = FindObjectOfType<GameLevel>();
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
                level.Lose();
                audioData.PlayOneShot(loseAudioClip);
            }
            else
            {
                Destroy(collider);
                audioData.PlayOneShot(hitAudioClip);
            }
        }
    }
}
