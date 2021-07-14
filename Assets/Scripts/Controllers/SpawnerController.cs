using UnityEngine;

namespace Controller 
{ 
    public class SpawnerController : MonoBehaviour
    {
        public GameObject signsPrefab;
    
        void Start()
        {
            Instantiate(signsPrefab, new Vector2(transform.position.x, -0.8410875f), Quaternion.identity);
        }

    }
}