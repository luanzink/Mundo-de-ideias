using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("World_selection");
    }

    public void TutorialButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Loja()
    {
        SceneManager.LoadScene("Loja");
    }


}
