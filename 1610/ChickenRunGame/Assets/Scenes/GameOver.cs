using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


    public GameObject player;

	// Use this for initialization
	IEnumerator OnCollisionEnter (Collision other) {

        if(other.gameObject == player)
        yield return new WaitForSeconds(0);
        SceneManager.LoadScene("Scene1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
