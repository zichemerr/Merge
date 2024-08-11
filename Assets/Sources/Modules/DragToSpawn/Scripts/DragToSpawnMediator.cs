using Drag;
using SpawnSystem;
using Circe;
using UnityEngine;

namespace DragToSpawn
{
    public class DragToSpawnMediator : MonoBehaviour
    {
        [SerializeField] private SpawningRoot _spawningRoot;
        [SerializeField] private DragRoot _dragRoot;

        public void Init()
        {
            _spawningRoot.Spawned += OnSpawned;
        }

        private void OnDisable()
        {
            _spawningRoot.Spawned -= OnSpawned;
        }

        private void OnSpawned(Circle circle)
        {
            _dragRoot.SetDragable(circle);
        }
}
}
