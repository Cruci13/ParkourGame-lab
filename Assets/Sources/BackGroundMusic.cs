using UnityEngine;

namespace Sources
{
    public class BackGroundMusic : MonoBehaviour
    {
        private AudioSource _audioSource;
        
        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.Play();
        }
        
        private void Update()
        {
            _audioSource.volume = AudioManager.Instance.Volume;
        }
    }
}