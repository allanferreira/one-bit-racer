using Controller;
using UnityEngine;

namespace Mechanic
{
    public class SignVisibility : MonoBehaviour
    {
        private SignsController controller;
      
        void Awake()
        {
            controller = GetComponent<SignsController>();
            
            foreach (var sign in controller.SignsToDisable())
            {
                sign.SetActive(false);
            }  
        }
    }
}