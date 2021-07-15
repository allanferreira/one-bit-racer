using System.Collections;
using UnityEngine;

namespace Controller 
{ 
    public class SpawnerController : MonoBehaviour
    {
        public GameObject signsPrefab;
        private LevelController level;

        void Awake()
        {
            level = FindObjectOfType<LevelController>();
            StartCoroutine(SpawnCoroutine());
        }

        IEnumerator SpawnCoroutine()
        {
            while (true)
            {
                Spawn();
                yield return new WaitForSeconds(SignsSpawnTimerInSecondsRule());
            }
        }

        void Spawn()
        {
            Instantiate(signsPrefab, new Vector2(transform.position.x, -0.8410875f), Quaternion.identity);
        }

        float SignsSpawnTimerInSecondsRule()
        {
            if (level.Difficulty >= 2) return .8f;
            else if (level.Difficulty >= 5) return .3f;
            else return 1.5f;
        }
    }
}