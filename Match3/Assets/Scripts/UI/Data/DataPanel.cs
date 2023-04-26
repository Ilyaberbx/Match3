using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Data
{
    public class DataPanel : MonoBehaviour
    {
        [SerializeField] private Button _closeButton;
        [SerializeField] private TextMeshProUGUI _conversionInfo;
        [SerializeField] private CanvasGroup _canvasGroup;

        private void Awake()
            => _closeButton.onClick.AddListener(Close);

        public void Open()
        {
            _canvasGroup.DOFade(1, 1f).OnComplete(() =>
            {
                _canvasGroup.interactable = true;
                _canvasGroup.blocksRaycasts = true;
            });

            UpdateUI();
        }

        private void UpdateUI()
        {

        }

        private void Close()
            => _canvasGroup.DOFade(0, 1f).OnComplete(() =>
            {
                _canvasGroup.interactable = false;
                _canvasGroup.blocksRaycasts = false;
            });
    }
}