using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public WorldManager wm;

    private void Start()
    {
        wm = FindObjectOfType<WorldManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void World1()
    {
        SceneManager.LoadScene("World1");
    }
    public void World2()
    {
        if(wm.world1 == true || PlayerPrefs.GetInt("World1") == 1)
            SceneManager.LoadScene("World2");
    }

    public void World3()
    {
        if(wm.world2 == true || PlayerPrefs.GetInt("World2") == 1)
            SceneManager.LoadScene("World3");
    }

    public void World4()
    {
        if(wm.world3 == true || PlayerPrefs.GetInt("World3") == 1)
        SceneManager.LoadScene("World4");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
