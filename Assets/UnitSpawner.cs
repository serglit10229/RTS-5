using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class UnitSpawner : MonoBehaviour {
    // unit prefab
    public GameObject unit;
    public float spawnRange = 1.5f;

    public float x = 0.075f;
    public float y = 0.5f;
    public float z = -0.1f;
    //public float angle = Random.Range(0.0f, 0.0f);
    public float speed1 = 0.2f;
    public float speed2 = 0.2f;


    public void OnMouseDown()
    {
        // start new animation
        //GetComponent<PlayCurve>().Toggle();
        
        // create a new unit at some random position around this place
        Vector3 pos = transform.position;

        Instantiate(unit, new Vector3(x + pos.x, y + pos.y, z + pos.z), Quaternion.Euler(0.0f, 0.0f, 0.0f));
        unit.GetComponent<NavMeshAgent>().enabled = false;

        unit.GetComponent<NavMeshAgent>().enabled = true;
    }
}