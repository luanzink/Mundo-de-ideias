using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SensorScript : MonoBehaviour
{
    public Movement player;

    private Vector3 lastPlayerPos;
    private float distanceToMove;

    public GameObject gameOverCanvas;

    void Start()
    {
        player = FindObjectOfType<Movement>();
        lastPlayerPos = player.transform.position;
    }


    void Update()
    {
        distanceToMove = player.transform.position.x - lastPlayerPos.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPos = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.vidas -= 3;          
            Debug.Log(player.vidas);


            if (player.vidas <= 0)
            {
                gameOverCanvas.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("Morreu.");
            }
        }

    }
}
