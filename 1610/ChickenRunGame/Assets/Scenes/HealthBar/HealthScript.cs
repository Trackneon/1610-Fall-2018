using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

    public FloatData currentHealth;
    //public RectTransform HealthBar;
    public Image image;

    void Start()
    {
        currentHealth.Value = 1;
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
            SceneManager.LoadScene("Scene3");
        }

    }

    public void GainHealth(FloatData data)
    {
        currentHealth.Value += data.Value;
        if (currentHealth.Value >= 1)
        {
            currentHealth.Value = 1;
            
        }

    }

}
