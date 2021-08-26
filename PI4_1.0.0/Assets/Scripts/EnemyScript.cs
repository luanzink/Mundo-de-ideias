using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Movement player;
    public GameObject gameOverCanvas;

    void Start()
    {
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.vidas -= 1;
            Destroy(this.gameObject);
            Debug.Log(player.vidas);

            if (player.vidas <= 0)
            {
                Time.timeScale = 0;
                gameOverCanvas.SetActive(true);
                Debug.Log("Morreu");
            }
        }
    }
}
