using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    GameObject buttonPrefab;

    void Awake()
    {
        buttonPrefab = Resources.Load<GameObject>("ugui/Button");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ENEMY")
        {
            Vector3 tmp = GameObject.Find("Bullet").transform.position;
            Debug.Log(tmp.x);
            Debug.Log(tmp.y);
        }
    }

            void Start()
    {
        var instance = Instantiate(buttonPrefab);
        instance.transform.SetParent(gameObject.transform, false);
    }

}
