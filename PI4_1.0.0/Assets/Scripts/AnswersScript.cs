using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersScript : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button buttonCorrect;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AJDSJJClick()
    {
        button1.image.color = new Color(1, 0, 0);
        button2.image.color = new Color(1, 0, 0);
        button3.image.color = new Color(1, 0, 0);
        buttonCorrect.image.color = new Color(0, 1, 0);
    }
}
