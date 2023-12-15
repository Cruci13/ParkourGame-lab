using UnityEngine;
using UnityEngine.UI;

namespace Sources
{
    public class AudioManager : MonoBehaviour
    {
        #region Instance

        public static AudioManager Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        public float Volume { get; private set; }

        private void Start()
        {
            Volume = PlayerPrefs.GetFloat("Volume", 1f);
        }

        public void SetVolume(Slider slider)
        {
            AudioListener.volume = slider.value;
            PlayerPrefs.SetFloat("Volume", slider.value);
        }
    }
}