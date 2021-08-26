using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class AdsManager : MonoBehaviour
{ 
    string gameId = "";
    //bool testMode = true;

   // int timeout = 3;


    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("PURCHASED_REMOVEADS"));
        ShowBanner();
        //ShowInterstitialAd();
        
        DontDestroyOnLoad(this);
#if UNITY_IOS
        gameId = "3815712";
#elif UNITY_ANDROID
        gameId = "3815713";
#endif

        //Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, Debug.isDebugBuild);
    }

    public void OnUnityAdsReady(string placementId)
    {
        if (placementId.Equals("banner"))
        {
            ShowBanner();
        }
    }

    public void ShowInterstitialAd()
    {
        if (PlayerPrefs.GetInt("PURCHASED_REMOVEADS") == 1) return;
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

    public void ShowRewarded()
    {
        HideBanner();
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
        }
        /*else
        {
            timeout = 15;
            closeButton.gameObject.SetActive(true);
            closeButton.interactable = false;
            closeImage.fillAmount = 0;
            backfillRewarded.SetActive(true);
            Invoke("RewardUser", timeout);
        }*/
    }

    public void RewardUser()
    {
        Debug.Log("Success.");
        //Time.timeScale = 1;
    }

    public void ShowBanner()
    {
        if (PlayerPrefs.GetInt("PURCHASED_REMOVEADS") == 1) return;
        if (Advertisement.IsReady("banner"))
        {
            //backfillBanner.SetActive(false);
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show("banner");
        }
        //else
        //{
            //backfillBanner.SetActive(true);
            //Advertisement.Banner.Hide();
        //}
    }

    public void HideBanner()
    {
        //backfillBanner.SetActive(false);
        Advertisement.Banner.Hide();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        ShowBanner();
        if (placementId == "rewardedVideo" && showResult == ShowResult.Finished)
        {
            RewardUser();
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.LogError("UNITY ADS ERROR: " + message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //executa quando um video comeca a ser mostrado na tela
    }

    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id.Equals("removeAds"))
        {
            PlayerPrefs.SetInt("PURCHASED_REMOVEADS", 1);
            PlayerPrefs.Save();
            HideBanner();
        }
    }
}
