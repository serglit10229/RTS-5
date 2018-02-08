using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlameNekit : MonoBehaviour {

    //destination coordinates
    float DoX = 0;
    float DoZ = 0;

    //Object coordinates
    float UoX = 0;
    float UoZ = 0;

    //selected units #
    int selected_units = 0;

    //radius of the circle
    int r = 0;

    //radius multiplier
    int mult = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Get coordinates from MoveByPlayer
        DoX = GetComponent<MoveByPlayer>().dest.x;
        DoZ = GetComponent<MoveByPlayer>().dest.z;

        //Get coordinates from MoveByPlayer
        UoX = transform.position.x;
        UoZ = transform.position.z;


    }
}
