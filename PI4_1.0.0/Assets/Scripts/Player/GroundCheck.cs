using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask ground;

    public bool isGrounded;
    GameObject player;

    private void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        isGrounded = collider != null && (((1 << collider.gameObject.layer) & ground) != 0);
        player.GetComponent<Movement>().isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.GetComponent<Movement>().isGrounded = false;
    }
}
