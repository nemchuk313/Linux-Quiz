using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    //priv
    [SerializeField]
    private GameObject explosion;
    [SerializeField]
    private GameObject respawn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //nie po stringach, a po getcomponent
        if (other.gameObject.name == "DeathCollider")
        { 
            transform.position = respawn.transform.position;

        }
    }
}