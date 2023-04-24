using System.Collections.Generic;
using AppsFlyerSDK;
using UnityEngine;

public class AppsflyerCacher : MonoBehaviour, IAppsFlyerConversionData
{
    private const string DevKey = "p6kCY8PcXysqHoQVFRmowj";
    
    public Dictionary<string, object> ConversionDataDictionary => _conversionDataDictionary;
    
    private Dictionary<string, object> _conversionDataDictionary;
    private void Start() 
        => Initialize();

    private void Initialize()
    {
        AppsFlyer.setIsDebug(true);
        AppsFlyer.initSDK(DevKey, string.Empty, this);
        AppsFlyer.startSDK();
    }

    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
        _conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
    }

    public void onConversionDataFail(string error) 
        => AppsFlyer.AFLog("onConversionDataFail", error);

    public void onAppOpenAttribution(string attributionData) {}
    

    public void onAppOpenAttributionFailure(string error) 
        => AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
}