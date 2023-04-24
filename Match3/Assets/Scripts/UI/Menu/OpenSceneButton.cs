﻿using System.Collections.Generic;
using AppsFlyerSDK;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI.Menu
{
    public class OpenSceneButton : MonoBehaviour
    {
        [SerializeField] private string _sceneKey;
        [SerializeField] private Button _button;

        private void Awake() 
            => _button.onClick.AddListener(Execute);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Execute);

        private void Execute()
        {
            AppsFlyer.sendEvent("play",new Dictionary<string, string>());
            SceneManager.LoadSceneAsync(_sceneKey);
        }
    }
}