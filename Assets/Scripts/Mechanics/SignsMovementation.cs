using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanic
{
    public class SignsMovementation : MonoBehaviour
    {
        private SignsController controller;

        void Start()
        {
            controller = GetComponent<SignsController>();
        }

        void Update()
        {
            controller.MoveForward();
        }
    }
}