using UnityEngine;
using System.Collections;

public class CastlePlayer : MonoBehaviour {       
    // Note: OnMouseDown only works if object has a collider
    void OnMouseDown() {
        // use UnitSpawner
        Debug.Log("MouseDown");
        //GetComponent<UnitSpawner>().Spawn();
    }
}