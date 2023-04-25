using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string _androidGameId = "5183277";
    [SerializeField] string _iOSGameId = "5183276";
    [SerializeField] bool _testMode = true;
    private string _gameId;

    void Awake()
    {
        InitializeAds();
    }

    public void InitializeAds()
	{
		//_gameId = _androidGameId;
		 _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
		  ? _iOSGameId
		  : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, this);
    }

    public void OnInitializationComplete()
    {
	    Debug.Log("Unity Ads initialization complete.");
	    FindObjectOfType<RewardedAds>().LoadAd();
	    FindObjectOfType<InterstitialAd>().LoadAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
}
