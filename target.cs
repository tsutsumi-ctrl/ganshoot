using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("1"))
        {
            Vector3 tmp = GameObject.Find("Plane.002").transform.position;
            GameObject.Find("Plane.002").transform.position = new Vector3(tmp.x, tmp.y, 20);
        }

        if (Input.GetKeyDown("2"))
        {
            Vector3 tmp = GameObject.Find("Plane.002").transform.position;
            GameObject.Find("Plane.002").transform.position = new Vector3(tmp.x, tmp.y, 48);
        }

        if (Input.GetKeyDown("3"))
        {
            Vector3 tmp = GameObject.Find("Plane.002").transform.position;
            GameObject.Find("Plane.002").transform.position = new Vector3(tmp.x, tmp.y, 75);
        }


    }
}
