using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject objTarget;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
		updatePostion();
	}

    private void LateUpdate()
    {
        updatePostion();
    }

    // Update is called once per frame
    void updatePostion () {
        Vector3 pos = objTarget.transform.localPosition;

        transform.localPosition = pos + offset;
	}
}
