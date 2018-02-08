using UnityEngine;
using System.Collections;

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
        Debug.Log("Spawn");
        while (unit.transform.localPosition.z <= 0.8)
        {
            Debug.Log("T1");
            unit.transform.Translate(0,0, speed1);
            if (unit.transform.localPosition.z >= 0.8)
            {
                Debug.Log("break1");
                break;
            }
        }
        if (unit.transform.localPosition.z >= 0.8)
        {
            while (unit.transform.localPosition.z <= 2.125 && unit.transform.localPosition.y >= 0.5)
            {
                Debug.Log("T2");
                unit.transform.Translate(0, speed2, speed1);
                if (unit.transform.localPosition.z >= 2.125 || unit.transform.localPosition.y <= 0.5)
                {
                    Debug.Log("break2");
                    break;
                }
            }
        }
    }
}