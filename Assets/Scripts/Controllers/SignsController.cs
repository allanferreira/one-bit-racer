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
        public int LEVEL = 1;
        public float CARSPEED = 3f;

        void Start()
        {
            signs = GetComponentsInChildren<Transform>()
                        .Select(children => children.gameObject)
                        .Where(gameObject => gameObject.CompareTag("Sign"))
                        .ToList();
        }

        public List<GameObject> SignsToDisable()
        {
            return signs
                       .OrderBy(a => Guid.NewGuid())
                       .Where((sign, index) => index >= LEVEL)
                       .ToList();
        }

        public void MoveForward()
        {
            transform.Translate(Vector3.left * CARSPEED * Time.deltaTime);
        }
    }
}