using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.Advertisements;

public class RewardedAds : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidAdUnitId = "Rewarded_Android";
    [SerializeField] string _iOSAdUnitId = "Rewarded_iOS";
	string _adUnitId = null;
	private Parameters parameter;
	public GameObject manager;

    void Awake()
	{
		parameter = manager.GetComponent<Parameters>();
#if UNITY_IOS
        _adUnitId = _iOSAdUnitId;
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif
    }

    public void LoadAd()
    {
        Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
    }
	
	
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
	    Debug.Log("Ad Loaded: " + adUnitId);
        
	    parameter.RewardButton.SetActive(true);
		
	    /*
        if (adUnitId.Equals(_adUnitId))
        {
            ShowAd();
	    }
	    */
    }
	

    public void ShowAd()
    {
	    Advertisement.Show(_adUnitId, this);
	    parameter.RewardButton.SetActive(false);
	    
    }

    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
	        Debug.Log("Unity Ads Rewarded Ad Completed");
            
	        parameter.CurrentGold = int.Parse(parameter.CoinsText.text);
	        parameter.CurrentGold = parameter.CurrentGold + 40;
	        parameter.RewardAdsDialog.SetActive(false);
	        
	        LoadAd();
	        //Advertisement.Load(_adUnitId, this);
        }
    }

    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit {adUnitId}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }

    void OnDestroy()
	{
    	
    }
}