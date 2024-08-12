using Drag;
using SpawnSystem;
using DragToSpawn;
using UnityEngine;
using RestartGame;
using Finish;
using FinishToRestart;
using Score;

namespace Game
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private DragRoot _dragRoot;
        [SerializeField] private SpawningRoot _spawningRoot;
        [SerializeField] private DragToSpawnMediator _spawningMediator;
        [SerializeField] private FinishRoot _finishRoot;
        [SerializeField] private GameRestart _gameRestart;
        [SerializeField] private FinishToRestartMediator _finishToRestartMediator;
        [SerializeField] private ScoreCounter _scoreCounter;

        private void Start()
        {
            _dragRoot.Init();
            _spawningRoot.Init();
            _spawningMediator.Init();
            _finishRoot.Init();
            _gameRestart.Init();
            _finishToRestartMediator.Init();
            _scoreCounter.Init();
        }
    }
}
