using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePosition : MonoBehaviour
{
    public GameObject ship;
 
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = ship.transform.position;
        pos.y += 1.5f;
        transform.position = pos;

    }
}
