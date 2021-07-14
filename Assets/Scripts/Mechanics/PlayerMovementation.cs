using Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanic
{
    public class PlayerMovementation : MonoBehaviour
    {
        private PlayerController controller;
        private bool upInput;
        private bool downInput;
        private float distance = 60f;

        void Start()
        {
            controller = GetComponent<PlayerController>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                upInput = true;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                downInput = true;
            }
        }

        void FixedUpdate()
        {
            if (upInput)
            {
                upInput = false;
                controller.MoveUp(distance);
            }

            if (downInput)
            {
                downInput = false;
                controller.MoveDown(distance);
            }

        }
    }
}