using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sources
{
    public class ExitButton : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(Application.Quit);
        }
    }
}