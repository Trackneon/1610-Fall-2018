using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPickUp : MonoBehaviour {

    HealthScript playerHealth;
    

    void Awake()
    {
        playerHealth = FindObjectOfType<HealthScript>();
    }

    void OnTriggerEnter(Collider other)
    {
       //if (playerHealth.currentHealth < playerHealth.)
        {
        //   playerHealth += ;
        }

    }


}
