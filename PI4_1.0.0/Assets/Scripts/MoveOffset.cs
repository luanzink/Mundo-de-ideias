using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{
    public float bgSpeed;
    public Renderer bgRenderer;

    //public CameraController cam;

    //private Vector3 lastCamPos;
    //private float distanceToMove;

    void Start()
    {
        //cam = FindObjectOfType<CameraController>();
       // lastCamPos = cam.transform.position;
    }


    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);

       // distanceToMove = cam.transform.position.x - lastCamPos.x;

        //transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        //lastCamPos = cam.transform.position;
    }
}
