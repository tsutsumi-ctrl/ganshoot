using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttack : MonoBehaviour {

    double tagetx;
    double tagety;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ENEMY")
        {
            Vector3 tmp =this.transform.position;
            Debug.Log(tmp.x);
            tagetx=(tmp.x - 8.44) / 2;
            Debug.Log(tmp.y);
            tagety = (tmp.x -146.2) / 2;

        }
    }
}
