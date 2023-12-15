using System;
using UnityEngine;

namespace Mini_First_Person_Controller.Scripts.Components
{
    public class OpenMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _menuPanel;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
                _menuPanel.SetActive(!_menuPanel.activeSelf);
        }
    }
}