using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableScript : MonoBehaviour
{
    public GameObject canvas;

    public Controller controller;



    void Start()
    {
        controller = FindObjectOfType<Controller>(); 
    }

    void Update()
    {

    }


    //---- Objeto de pergunta coletado ----
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            controller.perguntasNumero -= 1;
            Destroy(gameObject);
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
    }
}
