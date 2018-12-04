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
        if (playerHealth.currentHealth < playerHealth.max)
        {
            Destroy(gameObject);

            playerHealth.currentHealth += 40;
        }

    }

    void Update()
    {
        HealthScript;
        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
    }


}
