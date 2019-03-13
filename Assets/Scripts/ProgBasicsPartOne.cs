using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasicsPartOne : MonoBehaviour 
{

    int index = 0;
    int step = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        index += step;
        Debug.Log(index);
	}
}
