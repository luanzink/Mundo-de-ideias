using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldManager : MonoBehaviour
{
    public int starNumber = 0;
    public bool world1 = false;
    public bool world2 = false;
    public bool world3 = false;
    public bool world4 = false;

    public object Time { get; internal set; }

    //public Scene thisScene;

    void Awake()
    {
        DontDestroyOnLoad(this);
        //thisScene = thisScene = SceneManager.GetActiveScene();
    }

}
