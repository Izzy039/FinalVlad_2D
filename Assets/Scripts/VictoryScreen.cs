using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    public GameObject player;
    public GameObject victoryScreen;
    // Start is called before the first frame update
    void Start()
    {
        victoryScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            player.SetActive(false);
            victoryScreen.SetActive(true);
        }

    }
}
