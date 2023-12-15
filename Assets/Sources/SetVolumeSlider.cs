using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sources
{
    public class SetVolumeSlider : MonoBehaviour
    {
        private Slider _slider;

        private void OnEnable()
        {
            _slider = GetComponent<Slider>();
            _slider.onValueChanged.AddListener(OnValueChanged);
            _slider.value = AudioManager.Instance.Volume;
        }
        
        public void OnValueChanged(float value)
        {
            AudioManager.Instance.SetVolume(_slider);
        }
    }
}