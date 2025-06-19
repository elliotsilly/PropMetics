using BepInEx;
using UnityEngine;

[BepInPlugin("com.elliot.gorillatag.propwardrobe", "PropWardrobe", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private GameObject satelliteWardrobe;

    void Update()
    {
        if (satelliteWardrobe == null)
        {
            var bayouMain = GameObject.Find("BayouMain");
            if (bayouMain != null)
            {
                var computerArea = bayouMain.transform.Find("ComputerArea");
                if (computerArea != null)
                {
                    var wardrobe = computerArea.Find("SatelliteWardrobe");
                    if (wardrobe != null)
                    {
                        satelliteWardrobe = wardrobe.gameObject;
                    }
                }
            }
        }

        if (satelliteWardrobe != null && !satelliteWardrobe.activeSelf)
        {
            satelliteWardrobe.SetActive(true);
        }
    }
}
