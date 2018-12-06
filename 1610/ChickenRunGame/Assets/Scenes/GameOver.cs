using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


    public GameObject player;

    // Use this for initialization
    private IEnumerator OnTriggerEnter (Collider other)
    {
        if(other.gameObject == player)
        {
           
            yield return new WaitForSeconds(0);
            //SceneManager.s("Scene1");
            SceneManager.LoadScene("Scene2");
        }

	}
	
}
