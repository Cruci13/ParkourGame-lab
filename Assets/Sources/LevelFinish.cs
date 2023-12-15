using System;
using UnityEngine;

namespace Sources
{
    public class LevelFinish : MonoBehaviour
    {
        [SerializeField] private GameObject _levelFinishPanel;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _levelFinishPanel.SetActive(true);
                other.gameObject.GetComponent<FirstPersonMovement>().enabled = false;
            }
        }
    }
}