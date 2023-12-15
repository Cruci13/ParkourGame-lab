using System;
using UnityEngine;

namespace Sources
{
    public class MenuPanel : MonoBehaviour
    {
        [SerializeField] private FirstPersonLook _firstPersonLook;

        private void OnEnable()
        {
            _firstPersonLook.Disable();
        }

        private void OnDisable()
        {
            _firstPersonLook.Enable();
        }

        private void OnDestroy()
        {
            _firstPersonLook.Enable();
        }
    }
}