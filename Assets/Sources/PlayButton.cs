using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Sources
{
    public class PlayButton : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Button>().onClick
                .AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
        }
        
    }
}