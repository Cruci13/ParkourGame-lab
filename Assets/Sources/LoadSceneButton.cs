using UnityEngine;

namespace Sources
{
    public class LoadSceneButton : MonoBehaviour
    {
        [SerializeField] private int _sceneId;
        
        private void Start()
        {
            GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneId));
        }
    }
}