using Controller;
using UnityEngine;

namespace Mechanic
{
    public class SignsMovementation : MonoBehaviour
    {
        private SignsController controller;

        void Awake()
        {
            controller = GetComponent<SignsController>();
        }

        void FixedUpdate()
        {
            controller.MoveForward();
        }
    }
}