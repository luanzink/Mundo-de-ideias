using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public GameObject canvasTxt;
    public Text txtResposta;
    public ScrollingBackground bg;
    public GameObject gameOverResume;
    public GameObject menuHUD;
    public Text vidaText;
    public Text pergText;

    public Movement player;
    public int perguntasNumero = 3;

    public Scene thisScene;

    public AdsManager am;


    void Start()
    {
        am = FindObjectOfType<AdsManager>();
        thisScene = SceneManager.GetActiveScene();
        player = FindObjectOfType<Movement>();
        bg = FindObjectOfType<ScrollingBackground>();
        
        //canvas.SetActive(false);
        //canvasTxt.SetActive(false);
        vidaText.text = player.vidas.ToString();
        pergText.text = perguntasNumero.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        vidaText.text = player.vidas.ToString();
        pergText.text = perguntasNumero.ToString();
    }

    public void SeAcertar()
    {   
        
        
        //canvas.SetActive(false);
        //canvasTxt.SetActive(true);
        //txtResposta.text = "Parabéns! Você acertou!";
        //txtResposta.color = new Color(0, 1, 0);
        StartCoroutine(Temp());
        
        //GameObject.FindWithTag("CP").SetActive(false);
        Time.timeScale = 1;
        
    }

    public void SeErrar()
    {
        
        //canvas.SetActive(false);
        //canvasTxt.SetActive(true);
        //txtResposta.text = "Infelizmente! Você errou!";
        //txtResposta.color = new Color(1, 0, 0);
        StartCoroutine(Temp());
        
        Time.timeScale = 1;
    }

    IEnumerator Temp()
    {
        bg.bgSpeed = 0;
        player.speed = 0;
        yield return new WaitForSeconds(2);

        bg.bgSpeed = 0.39f;
        player.speed = 4;
        GameObject.FindWithTag("CP").SetActive(false);
    }

    public void ButtonMenu()
    {
        Time.timeScale = 0;
        menuHUD.SetActive(true);
    }

    public void ButtonReset()
    {
        SceneManager.LoadScene(thisScene.name);
        Time.timeScale = 1;
    }

    public void ButtonMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void ButtonResume()
    {
        menuHUD.SetActive(false);
        Time.timeScale = 1;
    }

    public void NextMap()
    {
        SceneManager.LoadScene("World_Selection");
        Time.timeScale = 1;
    }

    public void ButtonContinue()
    {
        am.ShowRewarded();
        player.transform.position = player.xy;
        player.vidas = 1;
        //Time.timeScale = 0;
        //am.OnUnityAdsDidFinish("rewardedVideo", UnityEngine.Advertisements.ShowResult.Finished);
        StartCoroutine(TempContinue());
        Time.timeScale = 1;    
    }

    IEnumerator TempContinue()
    {
        bg.bgSpeed = 0;
        player.speed = 0;
        yield return new WaitForSeconds(3);

        bg.bgSpeed = 0.39f;
        player.speed = 4;
        gameOverResume.SetActive(false);
    }
}
