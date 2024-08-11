using UnityEngine;
using System.Collections;
using System;
using Circe;

namespace SpawnSystem
{
    public class SpawningRoot : MonoBehaviour
    {
        [SerializeField] private PlayerInput _input;
        [SerializeField] private Spawning _spawning;
        [SerializeField] private float _spawnDelay;

        private bool _isSpawning;

        public event Action<Circle> Spawned;

        public void Init()
        {
            _input.Up += OnSpawn;
            StartCoroutine(StartSpawnDelay());
        }

        private void OnDisable()
        {
            _input.Up -= OnSpawn;
        }

        private void OnSpawn()
        {
            if (CanSpawn() == false)
                return;

            StartCoroutine(StartSpawnDelay());
        }

        private IEnumerator StartSpawnDelay()
        {
            _isSpawning = true;
            yield return new WaitForSeconds(_spawnDelay);
            _spawning.Spawn(out Circle circle);
            Spawned?.Invoke(circle);
            _isSpawning = false;
        }

        private bool CanSpawn()
        {
            if (_isSpawning == false)
                return true;
            else
                return false;
        }
    }

}
