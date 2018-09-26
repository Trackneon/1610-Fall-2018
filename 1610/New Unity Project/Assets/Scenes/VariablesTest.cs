using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour {
    public bool IsTheChosenOne;

    public int PowerCount = 1;

    public float Energy = 1.0f;
    public float Power;

    public string PlayerName = "Trackneon";

    public Vector3 Location;

    private void Start()
    {
        print(PlayerName);
        print("has");
        print(Power + " power");

        if (IsTheChosenOne)
        {
            print(PlayerName + " is the Chosen One.");
        }
    }
}
