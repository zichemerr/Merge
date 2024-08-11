using UnityEngine;
using UnityEngine.SceneManagement;

namespace RestartGame
{
    public class GameRestart : MonoBehaviour
    {
        [SerializeField] private ButtonRestart _restartButton;

        private int _indexActiveScene;

        public void Init()
        {
            _indexActiveScene = SceneManager.GetActiveScene().buildIndex;
            _restartButton.Init(Restart);
        }

        private void Restart()
        {
            SceneManager.LoadScene(_indexActiveScene);
        }

        public void Enable()
        {
            _restartButton.Enable();
        }
    }
}

