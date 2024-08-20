using Michsky.MUIP;
using UnityEngine;
using YG;

namespace Reward
{
    public class RewardVideo : MonoBehaviour
    {
        [SerializeField] private ButtonManager _buttonManager;

        private void OnEnable()
        {
            _buttonManager.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _buttonManager.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            YandexGame.RewVideoShow(0);
        }
    }

}
