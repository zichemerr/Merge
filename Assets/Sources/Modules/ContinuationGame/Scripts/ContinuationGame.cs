using Finish;
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
            _menu.SetActive(false);
            _playerInput.Activate();
        }
    }

}
