using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour {


    public float speed;
    private Transform target;
    public bool isFollowing;
    public enum state
    {idle, isFollowing }
    public state State;
    public GameObject player;


	// Use this for initialization
	void Start () {
        target = player.transform;
	}
	
	// Update is called once per frame
	void Update () {

        switch (State) {
            case state.idle:
                break;
            case state.isFollowing:
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                break;
        }


	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject == player)
        {
            //isFollowing = true;
            State = state.isFollowing;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            State = state.idle;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<HealthScript>();
        if (health  != null)
        {
            health.LoseHealth(8);
        }
    }
}
