using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour {


    private NavMeshAgent agent;
    public Transform Destination;
    public FloatData data;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Destination != null) agent.destination = Destination.position;
	}

    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<HealthScript>();
        if (health != null)
        {
            health.LoseHealth(data);
        }
    }
}
