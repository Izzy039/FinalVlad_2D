using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public GameObject deathZones;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
