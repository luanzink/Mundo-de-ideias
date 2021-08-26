using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject canvas;
    public string thisScene;
    public WorldManager wm;
    public AdsManager ads;
    

    private void Start()
    {
        wm = FindObjectOfType<WorldManager>();
        ads = FindObjectOfType<AdsManager>();

        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            ads.ShowInterstitialAd();
            
            Time.timeScale = 0;           
            canvas.SetActive(true);
            ads.ShowInterstitialAd();

            DefineWorld();           
        }
    }

    private void DefineWorld()
    {
        switch (thisScene = SceneManager.GetActiveScene().name)
        {
            case "World1":
                wm.world1 = true;
                PlayerPrefs.SetInt("World1", 1);
                break;
            case "World2":
                wm.world2 = true;
                PlayerPrefs.SetInt("World2", 1);
                break;
            case "World3":
                wm.world3 = true;
                PlayerPrefs.SetInt("World3", 1);
                break;
            case "World4":
                wm.world4 = true;
                PlayerPrefs.SetInt("World4", 1);
                break;
        }
    }
}
