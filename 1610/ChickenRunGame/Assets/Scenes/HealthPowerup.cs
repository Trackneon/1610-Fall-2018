using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerup : MonoBehaviour {

    public FloatData data;
    public GameObject player;
    public FloatData currenthealth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject == player)
        {
            currenthealth.Value += data.Value;
            Destroy(gameObject);
        }   
    }
}
