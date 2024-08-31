using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class Reklama : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay;
    [SerializeField] private GameObject _sound;
    [SerializeField] private PlayerInput _playerInput;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Start()
    {
        StartCoroutine(StartRec());
    }

    private void OnEnable()
    {
        YandexGame.CloseFullAdEvent += Loh;
    }

    private void OnDisable()
    {
        YandexGame.CloseFullAdEvent -= Loh;
    }

    private void Loh()
    {
        _panel.SetActive(false);
        _playerInput.Activate();
        _sound.SetActive(true);
        StartCoroutine(StartRec());
    }

    private IEnumerator StartRec()
    {
        yield return new WaitForSeconds(_delay);
        _panel.SetActive(true);
        _playerInput.Deactivate();
        _sound.SetActive(false);
        _text.text = "3";
        yield return new WaitForSeconds(1f);
        _text.text = "2";
        yield return new WaitForSeconds(1f);
        _text.text = "1";
        yield return new WaitForSeconds(1f);
        _text.text = "0";
        YandexGame.FullscreenShow();
    }
}
