using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTrigger : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.name == "Player")
        {
            playerMovement.movement = true;
            gameObject.SetActive(false);
        }
    }
}
