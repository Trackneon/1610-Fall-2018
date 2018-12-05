using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public FloatData currentHealth;
    //public RectTransform HealthBar;
    public Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        //HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
        image.fillAmount = currentHealth.Value;
    }

    public void LoseHealth(FloatData data)
    {
        currentHealth.Value -= data.Value;
        if (currentHealth.Value <= 0)
        {
            currentHealth.Value = 0;
            Debug.Log("Game Over!");
        }

    }



}
