using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace RestartGame
{
    public class GameRestart : MonoBehaviour
    {
        [SerializeField] private ButtonRestart _restartButton;
        [SerializeField] private PlayerInput _playerInput;

        private int _indexActiveScene;

        public event Action Restarted;

        public void Init()
        {
            _indexActiveScene = SceneManager.GetActiveScene().buildIndex;
            _restartButton.Init(Restart);
        }

        private void Restart()
        {
            SceneManager.LoadScene(_indexActiveScene);
			Restarted?.Invoke();
		}

        public void Enable()
        {
            _restartButton.Enable();
			_playerInput.Deactivate();
		}
    }
}

