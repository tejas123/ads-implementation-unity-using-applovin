using UnityEngine;
using System.Collections;

public class AppLovinAdEventListener : MonoBehaviour
{
    void onAppLovinEventReceived(string ev)
    {
        Debug.Log(ev);

        if (ev.Contains("REWARDAPPROVEDINFO"))
        {
            // Split the string into its three components.
            char[] delimiter = { '|' };
            string[] split = ev.Split(delimiter);

            // Pull out and parse the amount of virtual currency.
            double amount = double.Parse(split[1]);

            // Pull out the name of the virtual currency
            string currencyName = split[2];

            // Do something with this info - for example, grant coins to the user
            //myFunctionToUpdateBalance(currencyName, amount);
        }

        if (string.Equals(ev, "DISPLAYEDINTER") || string.Equals(ev, "VIDEOBEGAN"))
        {
            Time.timeScale = 0.0f;
            AudioListener.pause = true;
        }

        if (string.Equals(ev, "HIDDENINTER") || string.Equals(ev, "VIDEOSTOPPED"))
        {
            Time.timeScale = 1.0f;
            AudioListener.pause = false;
        }

        if (string.Equals(ev, "LOADEDINTER"))
        {
            // The last ad load was successful.
            // Probably do AppLovin.ShowInterstitial();
        }
        if (string.Equals(ev, "LOADFAILED"))
        {
            // The last ad load failed.
        }
    }
}
