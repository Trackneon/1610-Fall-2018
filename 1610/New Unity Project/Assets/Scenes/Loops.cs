using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    // Use this for initialization

    public string[] Names;
    public GameObject[] Things;

	void Start () {
        for (int i = 0; i < Names.Length; i++)
        {
            print(Names[i]);
        }

        foreach (var thing in Things)
        {
            print(thing);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
