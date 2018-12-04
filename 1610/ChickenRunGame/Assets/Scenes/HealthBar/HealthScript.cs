using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public float max = 80;
    public const int maxHealth = 80;
    public int currentHealth = maxHealth;
    public RectTransform HealthBar;  

    public void LoseHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Game Over!");
        }

        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
    }

}
