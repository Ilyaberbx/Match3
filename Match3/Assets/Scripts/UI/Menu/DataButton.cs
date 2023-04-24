using UI.Data;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Menu
{
    public class DataButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private DataPanel _dataPanel;

        private void Awake() 
            => _button.onClick.AddListener(Execute);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Execute);

        private void Execute() 
            => _dataPanel.Open();
    }
}