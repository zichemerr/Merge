using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using Finish;

namespace RestartGame
{
    public class GameRestart : MonoBehaviour
    {
        [SerializeField] private ButtonRestart _restartButton;
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private GameObject _restartMenu;

        private int _indexActiveScene;

        public event Action Restarted;

        public void Init()
        {
            _indexActiveScene = SceneManager.GetActiveScene().buildIndex;
            _restartButton.Init(Restart);
        }

        public void Restart()
        {
            SceneManager.LoadScene(_indexActiveScene);
			Restarted?.Invoke();
		}

        public void Enable()
        {
            _restartMenu.SetActive(true);
			_playerInput.Deactivate();
		}
    }
}

