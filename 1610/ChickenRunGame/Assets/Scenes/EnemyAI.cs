using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour {


    public float speed;
    private Transform target;
    public bool isFollowing;
    public enum State
    {idle, isFollowing }
    public State state;
    public GameObject player;
    public FloatData data;


	// Use this for initialization
	void Start () {
        target = player.transform;
	}
	
	// Update is called once per frame
	void Update () {

        switch (state) {
            case State.idle:
                break;
            case State.isFollowing:
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                break;
        }


	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject == player)
        {
            //isFollowing = true;
            state = State.isFollowing;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == player)
        {
            state = State.idle;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<HealthScript>();
        if (health  != null)
        {
            health.LoseHealth(data);
        }
    }
}
