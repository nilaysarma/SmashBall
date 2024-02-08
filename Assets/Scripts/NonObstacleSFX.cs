using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonObstacleSFX : MonoBehaviour
{
    [SerializeField] private AudioSource hitSFX;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            hitSFX.Play();
        }
    }
}
