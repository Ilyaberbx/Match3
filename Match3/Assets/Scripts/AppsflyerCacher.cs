using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppsFlyerCacher : MonoBehaviour
{
    [SerializeField] private AppsFlyerObjectScript _appsFlyer;
    [SerializeField] private TextMeshProUGUI _text;

    private void Awake()
        => _appsFlyer.OnDataSuccess += CacheData;

    private void OnDestroy()
        => _appsFlyer.OnDataSuccess -= CacheData;

    private void CacheData(Dictionary<string, object> conversionDictionary)
    {
        _text.text = "";

        foreach (var key in conversionDictionary.Keys)
            _text.text += key + ":  " + conversionDictionary[key] + ";      ";
    }
}