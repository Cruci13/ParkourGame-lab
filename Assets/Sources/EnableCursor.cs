using System;
using UnityEngine;

namespace Sources
{
    public class EnableCursor : MonoBehaviour
    {
        private void Start()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}