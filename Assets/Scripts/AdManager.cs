using UnityEngine;
using System.Collections;

public class AdManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AppLovin.SetSdkKey("YOUR_SDK_KEY");   // Paste Your SDK Key
        AppLovin.InitializeSdk();
        AppLovin.SetUnityAdListener(gameObject.name);
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 200, 50), "Show Banner Ad"))
        {
            AppLovin.ShowAd();
        }
        if (GUI.Button(new Rect(0, 75, 200, 50), "Catch Interstitial"))
        {
            AppLovin.PreloadInterstitial();
        }
        if (GUI.Button(new Rect(0, 150, 200, 50), "Show Interstitial Ad"))
        {
            AppLovin.ShowInterstitial();
        }
        if (GUI.Button(new Rect(0, 225, 200, 50), "Hide Ad"))
        {
            AppLovin.HideAd();
        }
    }
}