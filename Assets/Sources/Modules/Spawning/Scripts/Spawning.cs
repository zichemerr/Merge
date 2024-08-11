using UnityEngine;
using Circe;

namespace SpawnSystem
{
    internal class Spawning : MonoBehaviour
    {
        [SerializeField] private Circle[] _circlePrefabs;
        [SerializeField] private Transform _spawnPoint;

        private Circle GetCircle()
        {
            int randomIndex = Random.Range(0, _circlePrefabs.Length);

            Circle circle = Instantiate(_circlePrefabs[randomIndex]);

            return circle;
        }

        internal void Spawn(out Circle circle)
        {
            circle = GetCircle();
            circle.SetPosition(_spawnPoint.position);
        }
    }
}

