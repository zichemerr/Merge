using Finish;
using SpawnSystem;
using UnityEngine;
using YG;

namespace GameContinuation
{
    public class ContinuationGame : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private GameObject _menu;
        [SerializeField] private ЯГовноКодер _яГовноКодер;
        [SerializeField] private FinishRoot _root;
        [SerializeField] private SpawningRoot _spawningRoot;

        public void Init()
        {
            YandexGame.RewardVideoEvent += OnContinue;
        }

        private void OnDisable()
        {
            YandexGame.RewardVideoEvent -= OnContinue;
        }

        private void OnContinue(int reward)
        {
            _яГовноКодер.ХренМоржовый();
            _root.Delay();
            //Time.timeScale = 1;
            _menu.SetActive(false);
            _playerInput.Activate();
            //_spawningRoot.StartSpawnDelay(0);
        }
    }

}
