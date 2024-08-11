using Finish;
using RestartGame;
using UnityEngine;

namespace FinishToRestart
{
    public class FinishToRestartMediator : MonoBehaviour
    {
        [SerializeField] private FinishRoot _finishRoot;
        [SerializeField] private GameRestart _gameRestart;
        
        public void Init()
        {
            _finishRoot.SetFinishAction(EnableGameRestart);
        }

        private void EnableGameRestart()
        {
            _gameRestart.Enable();
        }
    }
}
