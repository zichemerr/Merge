using Drag;
using SpawnSystem;
using DragToSpawn;
using UnityEngine;

namespace Game
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private DragRoot _dragRoot;
        [SerializeField] private SpawningRoot _spawningRoot;
        [SerializeField] private DragToSpawnMediator _spawningMediator;

        private void Start()
        {
            _dragRoot.Init();
            _spawningRoot.Init();
            _spawningMediator.Init();
        }
    }
}
