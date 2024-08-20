using Finish;
using UnityEngine;
using YG;

namespace GameContinuation
{
    public class ContinuationGame : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private GameObject _menu;
        [SerializeField] private ����������� _�����������;
        [SerializeField] private FinishRoot _root;

        private void OnEnable()
        {
            YandexGame.RewardVideoEvent += Continue;
        }

        private void OnDisable()
        {
            YandexGame.RewardVideoEvent -= Continue;
        }

        private void Continue(int value)
        {
            _�����������.������������();
            _root.Delay();
            _menu.SetActive(false);
            Time.timeScale = 1;
            _playerInput.Activate();
        }
    }

}
