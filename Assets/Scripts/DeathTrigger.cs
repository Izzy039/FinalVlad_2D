using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    //public CharacterController cc;
    public GameObject player;
    //public Animator animator;
    public bool revivir = false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            player.SetActive(false);
            Debug.Log("Dying");
            Invoke("Respawn", 2);
            revivir = false;

     
        }

    }
    public void Respawn()
    {
        revivir = true;
        //player.SetActive(true);
    }
}
